using GymManagement.Models;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace GymManagement.Data
{
    public class PTProgramRepository
    {
        public int SaveProgram(int memberId, List<PTProgramExercise> exercises)
        {
            using var connection = DatabaseHelper.GetConnection();
            using var transaction = connection.BeginTransaction();
            try
            {
                var deleteCmd = connection.CreateCommand();
                deleteCmd.Transaction = transaction;
                deleteCmd.CommandText = "DELETE FROM PTPrograms WHERE MemberId = @MemberId";
                deleteCmd.Parameters.AddWithValue("@MemberId", memberId);
                deleteCmd.ExecuteNonQuery();
                var insertProgCmd = connection.CreateCommand();
                insertProgCmd.Transaction = transaction;
                insertProgCmd.CommandText = @"
                    INSERT INTO PTPrograms (MemberId, DateCreated)
                    VALUES (@MemberId, @DateCreated);
                    SELECT last_insert_rowid();";
                insertProgCmd.Parameters.AddWithValue("@MemberId", memberId);
                insertProgCmd.Parameters.AddWithValue("@DateCreated", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                
                int programId = Convert.ToInt32(insertProgCmd.ExecuteScalar());
                foreach (var ex in exercises)
                {
                    var insertExCmd = connection.CreateCommand();
                    insertExCmd.Transaction = transaction;
                    insertExCmd.CommandText = @"
                        INSERT INTO PTProgramExercises (PTProgramId, ExerciseName, Sets, Reps)
                        VALUES (@PTProgramId, @ExerciseName, @Sets, @Reps)";
                    insertExCmd.Parameters.AddWithValue("@PTProgramId", programId);
                    insertExCmd.Parameters.AddWithValue("@ExerciseName", ex.ExerciseName);
                    insertExCmd.Parameters.AddWithValue("@Sets", ex.Sets);
                    insertExCmd.Parameters.AddWithValue("@Reps", ex.Reps);
                    insertExCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return programId;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public List<PTProgramExercise> GetProgramByMemberId(int memberId)
        {
            var exercises = new List<PTProgramExercise>();
            using var connection = DatabaseHelper.GetConnection();
            
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT e.* FROM PTProgramExercises e
                INNER JOIN PTPrograms p ON e.PTProgramId = p.Id
                WHERE p.MemberId = @MemberId
                ORDER BY e.Id ASC";
            cmd.Parameters.AddWithValue("@MemberId", memberId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                exercises.Add(new PTProgramExercise
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    PTProgramId = reader.GetInt32(reader.GetOrdinal("PTProgramId")),
                    ExerciseName = reader.GetString(reader.GetOrdinal("ExerciseName")),
                    Sets = reader.GetInt32(reader.GetOrdinal("Sets")),
                    Reps = reader.GetInt32(reader.GetOrdinal("Reps"))
                });
            }
            return exercises;
        }
    }
}
