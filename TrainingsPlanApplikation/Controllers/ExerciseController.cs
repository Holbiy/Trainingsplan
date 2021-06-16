using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrainingsPlanApplikation.Models.Domain;
using TrainingsPlanApplikation.Models.ViewModel;

namespace TrainingsPlanApplikation.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly ILogger<ExerciseController> _logger;

        public ExerciseController(ILogger<ExerciseController> logger)
        {
            _logger = logger;
        }

        public IActionResult add(TrainingPlan trainingPlan)
        {

            var model = new AddExerciseViewModel() {TrainingPlan = trainingPlan};
            return View(model); 
        }


        public IActionResult AddExerciseToPlan(AddExerciseViewModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
