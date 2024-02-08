using Examen.Models;
using Examen.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Examen.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IHomeRepository _homeRepository;

		public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
		{
			_homeRepository = homeRepository;
			_logger = logger;
		}

		public async Task<IActionResult> Index(string sterm="", int modelId=0)
		{
			
			IEnumerable<Phone> phones = await _homeRepository.GetPhones(sterm, modelId);
			IEnumerable<Model> models = await _homeRepository.Models();
            PhoneDisplayModel phoneModel = new PhoneDisplayModel
			{
				Phones = phones,
				Models = models,
				STerm = sterm,
				ModelId = modelId
			};
            return View(phoneModel);
		}

		public IActionResult Privacy()
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
