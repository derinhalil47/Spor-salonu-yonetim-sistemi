using Microsoft.Data.Sqlite;
using GymManagement.Models;

namespace GymManagement.Data
{
    public class MemberRepository
    {
        public List<Member> GetAll()
        {
            var members = new List<Member>();
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Members ORDER BY Id DESC";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                members.Add(MapMember(reader));
            }
            return members;
        }

        public List<Member> Search(string keyword)
        {
            var members = new List<Member>();
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Members 
                                WHERE FirstName LIKE @keyword 
                                OR LastName LIKE @keyword 
                                OR Phone LIKE @keyword
                                ORDER BY Id DESC";
            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                members.Add(MapMember(reader));
            }
            return members;
        }

        public Member? GetById(int id)
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Members WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
                return MapMember(reader);
            return null;
        }

        public int Add(Member member)
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Members (FirstName, LastName, Phone, Email, Gender, BirthDate, RegistrationDate, PhotoPath, IsActive)
                VALUES (@FirstName, @LastName, @Phone, @Email, @Gender, @BirthDate, @RegistrationDate, @PhotoPath, @IsActive);
                SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("@FirstName", member.FirstName);
            cmd.Parameters.AddWithValue("@LastName", member.LastName);
            cmd.Parameters.AddWithValue("@Phone", member.Phone ?? "");
            cmd.Parameters.AddWithValue("@Email", member.Email ?? "");
            cmd.Parameters.AddWithValue("@Gender", member.Gender ?? "");
            cmd.Parameters.AddWithValue("@BirthDate", member.BirthDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@RegistrationDate", member.RegistrationDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@PhotoPath", (object?)member.PhotoPath ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@IsActive", member.IsActive ? 1 : 0);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Update(Member member)
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                UPDATE Members SET 
                    FirstName = @FirstName,
                    LastName = @LastName,
                    Phone = @Phone,
                    Email = @Email,
                    Gender = @Gender,
                    BirthDate = @BirthDate,
                    PhotoPath = @PhotoPath,
                    IsActive = @IsActive
                WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", member.Id);
            cmd.Parameters.AddWithValue("@FirstName", member.FirstName);
            cmd.Parameters.AddWithValue("@LastName", member.LastName);
            cmd.Parameters.AddWithValue("@Phone", member.Phone ?? "");
            cmd.Parameters.AddWithValue("@Email", member.Email ?? "");
            cmd.Parameters.AddWithValue("@Gender", member.Gender ?? "");
            cmd.Parameters.AddWithValue("@BirthDate", member.BirthDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@PhotoPath", (object?)member.PhotoPath ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@IsActive", member.IsActive ? 1 : 0);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Members WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        public int GetTotalCount()
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Members";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public int GetActiveCount()
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Members WHERE IsActive = 1";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private Member MapMember(SqliteDataReader reader)
        {
            return new Member
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? "" : reader.GetString(reader.GetOrdinal("Phone")),
                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString(reader.GetOrdinal("Email")),
                Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? "" : reader.GetString(reader.GetOrdinal("Gender")),
                BirthDate = DateTime.TryParse(reader.IsDBNull(reader.GetOrdinal("BirthDate")) ? null : reader.GetString(reader.GetOrdinal("BirthDate")), out var bd) ? bd : DateTime.Now,
                RegistrationDate = DateTime.Parse(reader.GetString(reader.GetOrdinal("RegistrationDate"))),
                PhotoPath = reader.IsDBNull(reader.GetOrdinal("PhotoPath")) ? null : reader.GetString(reader.GetOrdinal("PhotoPath")),
                IsActive = reader.GetInt32(reader.GetOrdinal("IsActive")) == 1
            };
        }
    }
}
