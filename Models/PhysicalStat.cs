namespace GymManagement.Models
{
    public class PhysicalStat
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal BodyFat { get; set; }
        public DateTime DateRecorded { get; set; }

        public decimal BMI
        {
            get
            {
                if (Height <= 0) return 0;
                var heightInMeters = Height / 100;
                return Weight / (heightInMeters * heightInMeters);
            }
        }
    }
}