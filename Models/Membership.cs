namespace GymManagement.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DurationMonths { get; set; }
        public decimal TotalFee { get; set; }
        public string MembershipType { get; set; } = "Standart";
        public int RemainingDays => (EndDate.Date - DateTime.Today).Days;
        public bool IsExpired => RemainingDays <= 0;
        public bool IsExpiringSoon => RemainingDays > 0 && RemainingDays < 7;
        public string MemberFullName { get; set; } = string.Empty;
    }
}
