namespace eoifitnesswasm.Shared
{
    public class Exercise
    {
        public int Id { get; set; }
        public string? Icon { get; set; }
        public string? Name { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public TimeSpan Rest { get; set; }
        public TimeSpan Duration { get; set; }
    }

    public class Workout
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Heading { get; set; }
        public string? MainGoal { get; set; }
        public string? TrainingLevel { get; set; }
        public string? ProgramDuration { get; set; }
        public string? DaysPerWeek { get; set; }
        public string? TimePerWorkout { get; set; }
        public string? Equipment { get; set; }
        public string? Author { get; set; }
        public int Rounds { get; set; }
        public Uri? Link { get; set; }
        public List<Exercise>? Exercises { get; set; }
    }

    public class WorkoutsDB
    {
        public List<Workout> Workouts { get; set; }
    }
}
