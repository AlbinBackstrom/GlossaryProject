using Glossary_mvc.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Glossary_mvc.Controllers
{
	[Authorize]
	public class DoTestController : Controller
	{
		// variabel som hanterar loggning av errors (finns i NLog.config)
		private static Logger logger = LogManager.GetCurrentClassLogger();

		// GET: DoTest
		public ActionResult Index(int id)
		{
			TempData["TestId"] = id;
			DoTestModel model = new DoTestModel();

			using (GlossaryModel db = new GlossaryModel())
			{
				List<Word> words = (from w in db.Words
									where w.TestId == id
									select w).ToList();

				model.Words = words;
				List<string> guessedList = new List<string>();
				foreach (var item in words)
				{
					guessedList.Add("");
				}
				model.mGuessedWord = guessedList;
				return View(model);
			}
		}

		[HttpPost]
		public ActionResult GuessedWords(DoTestModel model)
		{
			int id = (int)TempData["TestId"];

			IEnumerable<string> word2FromDB = null;
			IEnumerable<string> word1FromDB = null;

			List<string> guessedWrongFromUser = new List<string>();
			List<string> guessedWordFromUser = new List<string>();
			List<string> word2FromDBList = new List<string>();
			List<string> facitWord2 = new List<string>();
			List<string> word1FromDBList = new List<string>();
			List<string> facitWord1 = new List<string>();
			List<string> guessedCorrect = new List<string>();

			//Ord som anv. har gissat och skrivit in i view DoTest/index
			guessedWordFromUser = model.mGuessedWord;

			if (model != null)
			{
				using (GlossaryModel db = new GlossaryModel())
				{
					word1FromDB = (from w in db.Words
								   where w.TestId == id
								   select w.Word1).ToList();

					word1FromDBList = word1FromDB.ToList();

					word2FromDB = (from w in db.Words
								   where w.TestId == id
								   select w.Word2).ToList();

					word2FromDBList = word2FromDB.ToList();


					//De korrekta svaren på översättningsspråket(word2) som användaren svarat fel på
					facitWord2 = word2FromDBList.Except(guessedWordFromUser).ToList();

					//De korrekta svaret/svaren på originalspråket(word1) som användaren svarat fel på
					facitWord1 = (from a in db.Words
								  where facitWord2.Contains(a.Word2)
								  select a.Word1).ToList();

					//De ord som användaren skrev in och som blev fel
					guessedWrongFromUser = guessedWordFromUser.Except(word2FromDB).ToList();

					//De ord som användaren skrev in och blev rätt
					guessedCorrect = facitWord2.Except(guessedWordFromUser).ToList();
				}
			}

			/*Skapar ett objekt av List<Answers> som ligger i DoTestModel 
               Objektet: FacitWord1 = Det korrekta svaret på originalspråket som användaren skrivit fel på
               FacitWord2 = Det korrekta svaret på översättningsspråket som användaren svarat fel på
               GuessedWrong = De felaktiga svaren som användaren har skrivit in    */

			List<Answers> answers = new List<Answers>();
			Answers objAnswer = new Answers();
			objAnswer.TestId = id;
			objAnswer.FacitWord1 = word1FromDBList;
			objAnswer.FacitWord2 = word2FromDBList;
			objAnswer.GuessedWrong = guessedWordFromUser;
			objAnswer.GueesedRight = guessedCorrect;
			objAnswer.CorrectAnswers = word1FromDBList.Count - facitWord2.Count; //Antal rätt användaren fick på testen
			objAnswer.NumberOfTotalWords = word1FromDBList.Count;             //Totalt antal ord i testet
			answers.Add(objAnswer);

			//Lagrar objektet in en session så det går att skicka på ett effektivt sätt mellan controllers
			Session["answerObject"] = objAnswer;
			return RedirectToAction("Result");
		}

		public ActionResult Result()
		{
			var model = (Answers)Session["answerObject"];
			Session["answerObject"] = null;
			int numCorrect = model.CorrectAnswers;
			int numTotal = model.NumberOfTotalWords;

			//Får fram procenten antal rätt från testet användaren gjort, efter det bestäms en viewbag som visas upp på nästkommande sida.
			int percentComplete = (int)Math.Round((double)(100 * model.CorrectAnswers) / model.NumberOfTotalWords);
			if (percentComplete < 50)
			{
				ViewBag.DisplayMessageNumbers = "Du fick " + numCorrect + " av " + numTotal + " rätt.";
				ViewBag.DisplayMessage = "Mindre än en hälften rätt. Fortsätt öva";
			}
			if (percentComplete == 50)
			{
				ViewBag.DisplayMessageNumbers = "Du fick " + numCorrect + " av " + numTotal + " rätt.";
				ViewBag.DisplayMessage = "Halvvägs mot alla rätt. Fortsätt öva";
			}
			if (percentComplete > 50 && percentComplete < 99)
			{
				ViewBag.DisplayMessageNumbers = "Du fick " + numCorrect + " av " + numTotal + " rätt.";
				ViewBag.DisplayMessage = "Fortsätt att öva så får du snart alla rätt";
			}
			if (percentComplete == 100)
			{
				ViewBag.DisplayMessageNumbers = "Du fick " + numCorrect + " av " + numTotal + " rätt.";
				ViewBag.DisplayMessage = "Alla rätt. Bra jobbat!";
			}
			return View(model);
		}

		public ActionResult SaveResult(int id, int numWords, int numCorrWords)
		{
			string username = System.Web.HttpContext.Current.User.Identity.Name;
			ResultModel resultModel = new ResultModel();
			List<ResultModel> resultModelList = new List<ResultModel>();

			Result newResult = new Result();

			using (GlossaryModel db = new GlossaryModel())
			{
				try
				{
					newResult.Date = DateTime.Now;
					newResult.CorrectWords = numCorrWords;
					newResult.NumberOfQuestions = numWords;
					newResult.TestId = id;
					db.Results.Add(newResult);
					db.SaveChanges();
				}
				catch (Exception e)
				{
					// loggar eventuellt error
					logger.Error(e, "Unable to save in database");
				}
			}
			return RedirectToAction("Index", "Result");
		}
	}
}