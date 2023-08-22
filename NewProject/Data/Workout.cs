namespace NewProject.Data
{
    public class Workout
    {
        public int WorkoutID { get; set; }
        public string WorkoutName { get; set; }
        public string Distance { get; set; }
        public string Speed { get; set; }
        public string Time { get; set; }
        public int SportID { get; set; }
        public string Id { get; set; }

        public Sport sport { get; set; }
    }
}
