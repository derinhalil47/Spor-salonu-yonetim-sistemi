namespace GymManagement.Models
{
    public class PTProgramExercise
    {
        public int Id { get; set; }
        public int PTProgramId { get; set; }
        public string ExerciseName { get; set; } = string.Empty;
        public int Sets { get; set; }
        public int Reps { get; set; }
    }
}
