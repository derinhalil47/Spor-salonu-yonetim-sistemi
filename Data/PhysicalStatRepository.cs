using GymManagement.Models;
using Microsoft.Data.Sqlite;

namespace GymManagement.Data
{
    public class PhysicalStatRepository
    {
        public List<PhysicalStat> GetByMemberId(int memberId)
        {
            var stats = new List<PhysicalStat>();
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM PhysicalStats WHERE MemberId = @MemberId ORDER BY DateRecorded DESC";
            cmd.Parameters.AddWithValue("@MemberId", memberId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                stats.Add(new PhysicalStat
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    MemberId = reader.GetInt32(reader.GetOrdinal("MemberId")),
                    Height = reader.GetDecimal(reader.GetOrdinal("Height")),
                    Weight = reader.GetDecimal(reader.GetOrdinal("Weight")),
                    BodyFat = reader.GetDecimal(reader.GetOrdinal("BodyFat")),
                    DateRecorded = DateTime.Parse(reader.GetString(reader.GetOrdinal("DateRecorded")))
                });
            }
            return stats;
        }

        public PhysicalStat? GetLatestByMemberId(int memberId)
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM PhysicalStats WHERE MemberId = @MemberId ORDER BY DateRecorded DESC LIMIT 1";
            cmd.Parameters.AddWithValue("@MemberId", memberId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new PhysicalStat
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    MemberId = reader.GetInt32(reader.GetOrdinal("MemberId")),
                    Height = reader.GetDecimal(reader.GetOrdinal("Height")),
                    Weight = reader.GetDecimal(reader.GetOrdinal("Weight")),
                    BodyFat = reader.GetDecimal(reader.GetOrdinal("BodyFat")),
                    DateRecorded = DateTime.Parse(reader.GetString(reader.GetOrdinal("DateRecorded")))
                };
            }
            return null;
        }

        public int Add(PhysicalStat stat)
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO PhysicalStats (MemberId, Height, Weight, BodyFat, DateRecorded)
                VALUES (@MemberId, @Height, @Weight, @BodyFat, @DateRecorded);
                SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("@MemberId", stat.MemberId);
            cmd.Parameters.AddWithValue("@Height", stat.Height);
            cmd.Parameters.AddWithValue("@Weight", stat.Weight);
            cmd.Parameters.AddWithValue("@BodyFat", stat.BodyFat);
            cmd.Parameters.AddWithValue("@DateRecorded", stat.DateRecorded.ToString("yyyy-MM-dd HH:mm:ss"));

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
