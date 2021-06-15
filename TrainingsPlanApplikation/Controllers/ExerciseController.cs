using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TrainingsPlanApplikation.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly ILogger<ExerciseController> _logger;

        public ExerciseController(ILogger<ExerciseController> logger)
        {
            _logger = logger;
        }

        public IActionResult add()
        {
            return View();
        }

        
    }
}
