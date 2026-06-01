using Microsoft.Data.Sqlite;
using GymManagement.Models;

namespace GymManagement.Data
{
    public class PaymentRepository
    {
        public int Add(Payment payment)
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Payments (MemberId, MembershipId, Amount, PaymentDate, PaymentMethod)
                VALUES (@MemberId, @MembershipId, @Amount, @PaymentDate, @PaymentMethod);
                SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("@MemberId", payment.MemberId);
            cmd.Parameters.AddWithValue("@MembershipId", (object?)payment.MembershipId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Amount", payment.Amount);
            cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public List<Payment> GetByMemberId(int memberId)
        {
            var list = new List<Payment>();
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Payments WHERE MemberId = @MemberId ORDER BY PaymentDate DESC";
            cmd.Parameters.AddWithValue("@MemberId", memberId);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(Map(reader));
            return list;
        }

        public List<Payment> GetAllWithMemberName()
        {
            var list = new List<Payment>();
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT p.*, m.FirstName || ' ' || m.LastName AS MemberFullName
                FROM Payments p
                INNER JOIN Members m ON p.MemberId = m.Id
                ORDER BY p.PaymentDate DESC";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var p = Map(reader);
                p.MemberFullName = reader.IsDBNull(reader.GetOrdinal("MemberFullName"))
                    ? "" : reader.GetString(reader.GetOrdinal("MemberFullName"));
                list.Add(p);
            }
            return list;
        }
        public decimal GetTotalPaidByMemberId(int memberId)
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COALESCE(SUM(Amount), 0) FROM Payments WHERE MemberId = @MemberId";
            cmd.Parameters.AddWithValue("@MemberId", memberId);
            var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToDecimal(result) : 0;
        }
        public decimal GetTotalPaidThisMonth()
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT COALESCE(SUM(Amount), 0) FROM Payments 
                                WHERE strftime('%Y-%m', PaymentDate) = strftime('%Y-%m', 'now')";
            var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToDecimal(result) : 0;
        }
        public decimal GetTotalRevenue()
        {
            using var connection = DatabaseHelper.GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COALESCE(SUM(Amount), 0) FROM Payments";
            var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToDecimal(result) : 0;
        }

        private Payment Map(SqliteDataReader reader)
        {
            return new Payment
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                MemberId = reader.GetInt32(reader.GetOrdinal("MemberId")),
                MembershipId = reader.IsDBNull(reader.GetOrdinal("MembershipId"))
                    ? null : reader.GetInt32(reader.GetOrdinal("MembershipId")),
                Amount = reader.GetDecimal(reader.GetOrdinal("Amount")),
                PaymentDate = DateTime.Parse(reader.GetString(reader.GetOrdinal("PaymentDate"))),
                PaymentMethod = reader.IsDBNull(reader.GetOrdinal("PaymentMethod"))
                    ? "Nakit" : reader.GetString(reader.GetOrdinal("PaymentMethod")),
            };
        }
    }
}
