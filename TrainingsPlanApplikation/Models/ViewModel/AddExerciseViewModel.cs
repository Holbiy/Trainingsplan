using TrainingsPlanApplikation.Models.Domain;

namespace TrainingsPlanApplikation.Models.ViewModel
{
    public class AddExerciseViewModel
    {
        public int TrainingPlanId { get; set; }

        public Exercise Exercise { get; set; } = new Exercise();
    }
}
