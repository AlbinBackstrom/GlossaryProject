using Glossary_mvc.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace Glossary_mvc.Controllers
{
	public class LoginController : Controller
	{
		// GET: Login
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(LoginModel userLogin)
		{
			bool validUser = false;

			// skickar med användarnamn och lösenord från modellen till metoden checkUser och får tillbaka true/false
			validUser = checkUser(userLogin.Username, userLogin.Password);

			// om användaren finns har inloggningen lyckats
			if (validUser == true)
			{
				FormsAuthentication.RedirectFromLoginPage(userLogin.Username, false);
			}
			return View();
		}

		private bool checkUser(string username, string password)
		{
			// skickar med lösenordet till hashfunktionen som hashar användarens lösenord
			string passwordHash = PasswordHash.sha256(password);

			using (GlossaryModel db = new GlossaryModel())
			{
				var user = from u in db.Users
						   where u.Username == username
						   && u.Password == passwordHash	// kollar så att det hashade lösenordet är samma som i db
						   select u;

				if (user.Count() == 1)
				{
					return true;
				}
				else
				{
					ViewBag.LoggedInFail = true;
					return false;
				}
			}
		}

		public ActionResult LogOut()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Index", "Home");
		}
	}
}

