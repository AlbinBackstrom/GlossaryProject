using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Glossary_mvc.Controllers
{
	[Authorize]
	public class ResultController : Controller
	{
		// variabel som hanterar loggning av errors (finns i NLog.config)
		private static Logger logger = LogManager.GetCurrentClassLogger();

		// GET: Result
		public ActionResult Index()
		{
			// hämtar den aktuellt inloggade användaren
			string username = System.Web.HttpContext.Current.User.Identity.Name;

			IEnumerable<Result> results = null;

			using (GlossaryModel db = new GlossaryModel())
			{
				int userId = (from u in db.Users
							  where u.Username == username
							  select u.Id).FirstOrDefault();

				// skapar en lista av test hos en specifik användare
				List<Test> tests = (from t in db.Tests
									where t.UserId == userId
									select t).ToList();

				// skapar en lista av ints med en användares alla testId
				List<int> testIds = (from i in tests
									 select i.Id).ToList();

				// hämtar alla test och resultat från en användaren med alla testID som denne har mha listan testIds
				results = (from r in db.Results
						   where testIds.Contains(r.TestId)
						   orderby r.Date descending
						   select r).ToList();
			}
			// skickar resultaten till vyn
			return View(results);
		}

		public ActionResult DeleteResult(int id)
		{
			int resultID = 0;
			using (GlossaryModel db = new GlossaryModel())
			{
				try
				{
					Result result = new Result();

					result = (from r in db.Results
							  where r.Id == id
							  select r).FirstOrDefault();

					if (result != null)
					{
						resultID = result.Id;
						db.Results.Remove(result);
						db.SaveChanges();
					}
				}
				catch (Exception e)
				{
					// loggar eventuellt error
					logger.Error(e, "Unable to save in database");
				}
			}
			return RedirectToAction("Index");
		}
	}
}