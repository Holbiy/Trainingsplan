using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TrainingsPlanApplikation.DataAccess;
using TrainingsPlanApplikation.Models.Domain;
using TrainingsPlanApplikation.Models.ViewModel;

namespace TrainingsPlanApplikation.Controllers
{
	public class PlanController : Controller
	{
		private readonly ILogger<PlanController> _logger;
		private readonly ITrainingPlanRepository _trainingPlanRepository;

		public PlanController(ILogger<PlanController> logger, ITrainingPlanRepository trainingPlanRepository)
		{
			_logger = logger;
			_trainingPlanRepository = trainingPlanRepository;
		}

		public IActionResult Index()
		{
			var model = new ShowAllTrainingPlansViewModel()
			{
				TrainingPlans = _trainingPlanRepository.GetAllTrainingPlans().ToList()
			};
			return View(model);
		}

        public IActionResult Delete(int id)
        {
            var trainingsplan = _trainingPlanRepository.GetTrainingPlanById(id);
            if (trainingsplan == null)
                return RedirectToAction(nameof(Index));

            _trainingPlanRepository.DeleteTrainingPlan(trainingsplan);

			return RedirectToAction(nameof(Index));
		}

		public IActionResult Show(int id)
		{
			var trainingsPlan = _trainingPlanRepository.GetTrainingPlanById(id);
			if(trainingsPlan == null)
				return View("Index");

			return View(trainingsPlan);
		}

		public IActionResult Edit(int id)
		{
            var trainingsPlan = _trainingPlanRepository.GetTrainingPlanById(id);
            if (trainingsPlan == null)
                return View("Index");

			return View(trainingsPlan);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
        public IActionResult Update(TrainingPlan trainingPlan)
        {
            _trainingPlanRepository.UpdateTrainingPlan(trainingPlan);
            return RedirectToAction("Index");
        }
    }
}
