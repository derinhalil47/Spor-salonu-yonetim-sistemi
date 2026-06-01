using System.Collections.Generic;
using GymManagement.Models;

namespace GymManagement.Data
{
    public static class ExerciseDataStore
    {
        public static List<Exercise> GetAllExercises()
        {
            var list = new List<Exercise>();
            list.Add(Create("Göğüs", "Barbell Bench Press", "https://musclewiki.com/tr-tr/exercises/chest/barbell"));
            list.Add(Create("Göğüs", "Incline Dumbbell Bench Press", "https://musclewiki.com/tr-tr/exercises/chest/dumbbells"));
            list.Add(Create("Göğüs", "Dips", "https://musclewiki.com/tr-tr/exercises/triceps/bodyweight"));
            list.Add(Create("Göğüs", "Cable Chest Fly", "https://musclewiki.com/tr-tr/exercises/chest/cables"));
            list.Add(Create("Sırt", "Barbell Row", "https://musclewiki.com/tr-tr/exercises/lats/barbell"));
            list.Add(Create("Sırt", "Pull Ups", "https://musclewiki.com/tr-tr/exercises/lats/bodyweight"));
            list.Add(Create("Sırt", "Deadlifts", "https://musclewiki.com/tr-tr/exercises/glutes/barbell"));
            list.Add(Create("Sırt", "Dumbbell Shrugs", "https://musclewiki.com/tr-tr/exercises/traps/dumbbells"));
            list.Add(Create("Sırt", "T Bar Rows", "https://musclewiki.com/tr-tr/exercise/landmine-t-bar-rows"));
            list.Add(Create("Karın", "Bicycle Crunches", "https://musclewiki.com/tr-tr/exercises/abdominals/bodyweight"));
            list.Add(Create("Karın", "Leg Raises", "https://musclewiki.com/tr-tr/exercises/abdominals/bodyweight"));
            list.Add(Create("Karın", "Russian Twists", "https://musclewiki.com/tr-tr/exercise/dumbbell-russian-twist"));
            list.Add(Create("Karın", "Med Ball V Ups", "https://musclewiki.com/tr-tr/exercise/stability-ball-v-up-pass"));
            list.Add(Create("Omuz", "Shoulder Press", "https://musclewiki.com/tr-tr/exercises/front-shoulders/barbell"));
            list.Add(Create("Omuz", "Upright Row", "https://musclewiki.com/tr-tr/exercises/front-shoulders/barbell"));
            list.Add(Create("Omuz", "Lateral Raises", "https://musclewiki.com/tr-tr/exercises/front-shoulders/dumbbells"));
            list.Add(Create("Omuz", "Frontal Raises", "https://musclewiki.com/tr-tr/exercise/dumbbell-front-raise?model=m"));
            list.Add(Create("Omuz", "Face Pulls", "https://musclewiki.com/tr-tr/exercises/rear-shoulders/cables"));
            list.Add(Create("Kol", "Palm Up Wrist Curls", "https://musclewiki.com/tr-tr/exercise/dumbbell-wrist-curl?model=m"));
            list.Add(Create("Kol", "Reverse Grip Curl", "https://musclewiki.com/tr-tr/exercises/forearms"));
            list.Add(Create("Kol", "Barbell Bicep Curl", "https://musclewiki.com/tr-tr/exercises/biceps"));
            list.Add(Create("Kol", "Dumbbell Curl", "https://musclewiki.com/tr-tr/exercises/biceps/dumbbells"));
            list.Add(Create("Kol", "Cable Bicep Curl", "https://musclewiki.com/tr-tr/exercises/biceps/cables"));
            list.Add(Create("Kol", "Skull Crusher", "https://musclewiki.com/tr-tr/exercises/triceps/barbell"));
            list.Add(Create("Kol", "Cable Triceps Pushdown", "https://musclewiki.com/tr-tr/exercises/triceps/cables"));
            list.Add(Create("Bacak", "Deadlift", "https://musclewiki.com/tr-tr/exercises/glutes/barbell"));
            list.Add(Create("Bacak", "Squats", "https://musclewiki.com/tr-tr/exercise/barbell-squat?model=m"));
            list.Add(Create("Bacak", "Leg Press", "https://musclewiki.com/tr-tr/exercises/quads/machine"));
            list.Add(Create("Bacak", "Calf Raise", "https://musclewiki.com/tr-tr/exercises/calves/machine"));

            return list;
        }

        private static Exercise Create(string category, string name, string videoUrl)
        {
            return new Exercise
            {
                Name = name,
                Category = category,
                VideoUrl = videoUrl
            };
        }
    }
}
