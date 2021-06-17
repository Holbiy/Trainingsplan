using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrainingsPlanApplikation.DataAccess;
using TrainingsPlanApplikation.Models.Domain;
using TrainingsPlanApplikation.Models.ViewModel;

namespace TrainingsPlanApplikation.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly ILogger<ExerciseController> _logger;
        private readonly ITrainingPlanRepository _trainingPlanRepository;

        public ExerciseController(ILogger<ExerciseController> logger, ITrainingPlanRepository trainingPlanRepository)
        {
            _logger = logger;
            _trainingPlanRepository = trainingPlanRepository;
        }

        public IActionResult Add(int id)
        {
            var model = new AddExerciseViewModel() { TrainingPlanId = id };
            return View(model);
        }


        public IActionResult AddExerciseToPlan(AddExerciseViewModel model)
        {
            _trainingPlanRepository.AddExerciseToTrainingPlan(model.TrainingPlanId, model.Exercise);

            return RedirectToAction("edit", "Plan", new { id = model.TrainingPlanId });
        }
    }
}
