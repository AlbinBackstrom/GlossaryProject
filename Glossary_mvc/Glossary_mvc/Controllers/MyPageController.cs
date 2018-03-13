using Glossary_mvc.Models;
using NLog;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Glossary_mvc.Controllers
{
	[Authorize]
	public class MyPageController : Controller
	{
		// variabel som hanterar loggning av errors (finns i NLog.config)
		private static Logger logger = LogManager.GetCurrentClassLogger();

		// GET: MyPage
		public ActionResult Index()
		{
			// sparar den aktuellt inloggade användaren i en variabel
			string username = System.Web.HttpContext.Current.User.Identity.Name;

			// skapar en instans av modellen userInfo
			UserModel userInfo = new UserModel();

			using (GlossaryModel db = new GlossaryModel())
			{
				User user = (from u in db.Users
							 where u.Username == username   // jämför den aktuellt inloggade användaren med användarnamnet i db
							 select u).FirstOrDefault();

				TempData["UserID"] = user.Id;  //Lagrar user ID i Tempdatan "UserId" så IDt kan användas globalt          
				userInfo.Firstname = user.Firstname;
				userInfo.Lastname = user.Lastname;
				userInfo.Username = user.Username;
				userInfo.Password = string.Empty;
				userInfo.Email = user.Email;
			}
			return View(userInfo);
		}

		[HttpPost]
		public ActionResult SaveUser(UserModel userInfo)
		{
			string username = System.Web.HttpContext.Current.User.Identity.Name;

			logger.Trace(String.Format("Save user {0}", userInfo.Username));
			using (GlossaryModel db = new GlossaryModel())
			{
				try
				{
					User user = (from u in db.Users
								 where u.Username == username
								 select u).FirstOrDefault();

					// sparar de nya uppgifterna om användaren i db
					user.Firstname = userInfo.Firstname;
					user.Lastname = userInfo.Lastname;
					user.Email = userInfo.Email;

					if (userInfo.Password != null)
					{
						string passwordHash = PasswordHash.sha256(userInfo.Password);
						user.Password = passwordHash;
					}

					db.SaveChanges();
					logger.Trace("User saved" + userInfo.Username);
				}
				catch (Exception e)
				{
					// loggar eventuellt error
					logger.Error(e, "Unable to save in database");
				}
			}
			return RedirectToAction("Index", "Home");
		}
	}
}