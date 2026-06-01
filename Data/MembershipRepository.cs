using Microsoft.Data.Sqlite;
using GymManagement.Models;

namespace GymManagement.Data
{
    public class MembershipRepository
    {
        public int Add(Membership membership)
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Memberships (MemberId, StartDate, EndDate, DurationMonths, TotalFee, MembershipType)
                VALUES (@MemberId, @StartDate, @EndDate, @DurationMonths, @TotalFee, @MembershipType);
                SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("@MemberId", membership.MemberId);
            cmd.Parameters.AddWithValue("@StartDate", membership.StartDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@EndDate", membership.EndDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@DurationMonths", membership.DurationMonths);
            cmd.Parameters.AddWithValue("@TotalFee", membership.TotalFee);
            cmd.Parameters.AddWithValue("@MembershipType", membership.MembershipType);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public List<Membership> GetByMemberId(int memberId)
        {
            var list = new List<Membership>();
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Memberships WHERE MemberId = @MemberId ORDER BY StartDate DESC";
            cmd.Parameters.AddWithValue("@MemberId", memberId);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(Map(reader));
            return list;
        }
        public Membership? GetLatestByMemberId(int memberId)
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Memberships WHERE MemberId = @MemberId 
                                ORDER BY StartDate DESC LIMIT 1";
            cmd.Parameters.AddWithValue("@MemberId", memberId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read()) return Map(reader);
            return null;
        }
        public List<Membership> GetAllWithMemberName()
        {
            var list = new List<Membership>();
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT ms.*, m.FirstName || ' ' || m.LastName AS MemberFullName
                FROM Memberships ms
                INNER JOIN Members m ON ms.MemberId = m.Id
                ORDER BY ms.StartDate DESC";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var ms = Map(reader);
                ms.MemberFullName = reader.IsDBNull(reader.GetOrdinal("MemberFullName"))
                    ? "" : reader.GetString(reader.GetOrdinal("MemberFullName"));
                list.Add(ms);
            }
            return list;
        }
        public List<Membership> GetExpired()
        {
            var list = new List<Membership>();
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT ms.*, m.FirstName || ' ' || m.LastName AS MemberFullName
                FROM Memberships ms
                INNER JOIN Members m ON ms.MemberId = m.Id
                WHERE date(ms.EndDate) < date('now')
                ORDER BY ms.EndDate DESC";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var ms = Map(reader);
                ms.MemberFullName = reader.IsDBNull(reader.GetOrdinal("MemberFullName"))
                    ? "" : reader.GetString(reader.GetOrdinal("MemberFullName"));
                list.Add(ms);
            }
            return list;
        }
        public int GetActiveCount()
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Memberships WHERE date(EndDate) >= date('now')";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public int GetExpiredCount()
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Memberships WHERE date(EndDate) < date('now')";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private Membership Map(SqliteDataReader reader)
        {
            return new Membership
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                MemberId = reader.GetInt32(reader.GetOrdinal("MemberId")),
                StartDate = DateTime.Parse(reader.GetString(reader.GetOrdinal("StartDate"))),
                EndDate = DateTime.Parse(reader.GetString(reader.GetOrdinal("EndDate"))),
                DurationMonths = reader.GetInt32(reader.GetOrdinal("DurationMonths")),
                TotalFee = reader.GetDecimal(reader.GetOrdinal("TotalFee")),
                MembershipType = reader.GetString(reader.GetOrdinal("MembershipType")),
            };
        }
    }
}
