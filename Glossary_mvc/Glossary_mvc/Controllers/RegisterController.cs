using NLog;
using System;
using System.Web.Mvc;
using System.Web.UI;

namespace Glossary_mvc.Controllers
{
	public class RegisterController : Controller
    {
		// variabel som hanterar loggning av errors (finns i NLog.config)
		private static Logger logger = LogManager.GetCurrentClassLogger();

		// GET: Register
		public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        [AllowAnonymous]
        [HttpPost]
        public ActionResult CheckUsername()
        {
            return View();
        }

        public ActionResult Create()
        { return View(); }

        //Tar in ett objekt av User som U och sparar sedan denna i databasen
        [HttpPost]
        public ActionResult Create(User NewUser)
        {
            if (ModelState.IsValid)
            {
                string passwordHash = PasswordHash.sha256(NewUser.Password);
                NewUser.Password = passwordHash;

                using (GlossaryModel db = new GlossaryModel())
                {
					try
					{
						db.Users.Add(NewUser);
						db.SaveChanges();
						ViewBag.SuccessResult = true;
					}
					catch (Exception e)
					{
						// loggar eventuellt error
						logger.Error(e, "Unable to save in database");

						ViewBag.SuccessResult = false;
					}
                    ModelState.Clear();
                    NewUser = null;
                }
            }
            return RedirectToAction("Index", "Login");
        }
    }
}






















