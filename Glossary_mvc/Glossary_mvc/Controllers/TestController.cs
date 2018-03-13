using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Glossary_mvc.Controllers
{
	[Authorize]
	public class TestController : Controller
	{
		// variabel som hanterar loggning av errors (finns i NLog.config)
		private static Logger logger = LogManager.GetCurrentClassLogger();

		// GET: Test
		public ActionResult Index()
		{
			// hämtar den aktuellt inloggade användaren
			string username = System.Web.HttpContext.Current.User.Identity.Name;

			// skapar en lista som ska innehålla test
			IEnumerable<Test> tests = null;

			using (GlossaryModel db = new GlossaryModel())
			{
				int userId = (from u in db.Users
							  where u.Username == username
							  select u.Id).FirstOrDefault();

				// fyller listan med testen hos en specifik användare
				// för att kunna visa upp vilket språk som är valt måste man inkludera den i queryn (language är en int i modellen)
				tests = (from t in db.Tests.Include("Language").Include("Language1")
						 where t.UserId == userId
						 select t).ToList();
			}
			// skickar testen till vyn
			return View(tests);
		}

		public ActionResult Create()
		{
			// hämtar språken från db och visar upp i vyn
			using (GlossaryModel db = new GlossaryModel())
			{
				ViewBag.Languages = db.Languages.ToList();
			}
			return View();
		}

		[HttpPost]
		public ActionResult Create(Models.TestModel newTest)
		{
			int testId = 0;
			using (GlossaryModel db = new GlossaryModel())
			{
				try
				{
					// hämtar språken och visar upp i en dropdown lista
					Languages lang = new Languages();
					lang.LangListMain = new SelectList(db.Languages, "Id", "Language");
					lang.LangListSec = new SelectList(db.Languages, "Id", "Language");
					ViewBag.Languages = db.Languages.ToList();

					// hämtar den inloggade användarens id från db
					string username = System.Web.HttpContext.Current.User.Identity.Name;
					int userId = (from u in db.Users
								  where u.Username == username
								  select u.Id).FirstOrDefault();

					// skapar en instans av klassen Test (från db) 
					Test test = new Test();

					// sparar testet i db från modellen
					test.Name = newTest.Name;
					test.MainLang = newTest.MainLang;
					test.SecLang = newTest.SecLang;
					test.Date = DateTime.Now;
					test.StatusId = 0;
					test.UserId = userId;

					db.Tests.Add(test);
					db.SaveChanges();
				
					// hämtar testId från det nyss skapade testet och skickar användaren vidare till nästa vy med det specifika id
					testId = test.Id;
				}
				catch (Exception e)
				{
					// loggar eventuellt error
					logger.Error(e, "Unable to save in database");
				}
			}
			return RedirectToAction("CreateWords", "Words", new { id = testId });
		}
	}
}
