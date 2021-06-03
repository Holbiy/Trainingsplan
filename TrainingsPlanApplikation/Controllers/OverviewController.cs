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
	public class OverViewController : Controller
	{
		private readonly ILogger<OverViewController> _logger;

		public OverViewController(ILogger<OverViewController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
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
