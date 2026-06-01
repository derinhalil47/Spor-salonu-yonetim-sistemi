namespace GymManagement.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int? MembershipId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public string PaymentMethod { get; set; } = "Nakit";
        public string MemberFullName { get; set; } = string.Empty;
    }
}
