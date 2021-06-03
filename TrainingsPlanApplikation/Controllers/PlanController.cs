using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrainingsPlanApplikation.Models;

namespace TrainingsPlanApplikation.Controllers
{
	public class PlanController : Controller
	{
		private readonly ILogger<PlanController> _logger;

		public PlanController(ILogger<PlanController> logger)
		{
			_logger = logger;
		}

		public IActionResult show()
		{
			return View();
		}

		public IActionResult edit()
		{
			return View();
		}

		public IActionResult create()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
