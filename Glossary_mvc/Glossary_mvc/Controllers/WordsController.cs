using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Glossary_mvc.Models;
using NLog;

namespace Glossary_mvc.Controllers
{
	[Authorize]
	public class WordsController : Controller
	{
		// variabel som hanterar loggning av errors (finns i NLog.config)
		private static Logger logger = LogManager.GetCurrentClassLogger();

		// tar in id som en inparameter från det skapade testet
		public ActionResult CreateWords(int id)
		{
			// gör en ny instans av modellen för att lägga till ord
			TestWordModel model = new TestWordModel();

			using (GlossaryModel db = new GlossaryModel())
			{
				// hämtar testet från db med samma id som skickades med som parameter
				Test test = (from t in db.Tests
							 where t.Id == id
							 select t).FirstOrDefault();

				// skapar en lista av ord som tillhör samma testId
				List<Word> words = (from w in db.Words
									where w.TestId == id
									select w).ToList();

				// sätter alla värden och skickar med modellen till vyn
				model.TestId = id;
				model.Name = test.Name;
				model.MainLang = test.MainLang;
				model.SecLang = test.SecLang;
				model.AddWord = new Word();
				model.AddWord.Word1 = string.Empty;
				model.AddWord.Word2 = string.Empty;
				model.Words = words;
				model.LangOne = test.Language.Language1;
				model.LangTwo = test.Language1.Language1;
			}
			// reurnerar modellen till vyn
			return View(model);
		}

		[HttpPost]
		public ActionResult SaveWord(TestWordModel model)
		{
			// sätter testId som samma id från modellen
			int testId = model.TestId;

			// sparar orden i db
			using (GlossaryModel db = new GlossaryModel())
			{
				try
				{
					Word word = model.AddWord;
					word.TestId = model.TestId;

					db.Words.Add(word);
					db.SaveChanges();
				}
				catch (Exception e)
				{
					// loggar eventuellt error
					logger.Error(e, "Unable to save in database");
				}
			}
			// redirectar till samma sida och skickar med samma testId så att användaren fortfarande är i samma test
			return RedirectToAction("CreateWords", "Words", new { id = testId });
		}

		public ActionResult UpdateWord(int id)
		{
			// när användaren vill uppdatera ett ord söker vi ut ordet med rätt id och skickar till vyn
			Word word = null;
			using (GlossaryModel db = new GlossaryModel())
			{
				word = (from w in db.Words
						where w.Id == id
						select w).FirstOrDefault();
			}
			return View(word);
		}

		[HttpPost]
		public ActionResult UpdatedWord(Word model)
		{
			// sätter testId som samma id från modellen och söker ut ordets id från db
			int testId = model.TestId;

			using (GlossaryModel db = new GlossaryModel())
			{
				try
				{
					Word word = (from w in db.Words
								 where w.Id == model.Id
								 select w).FirstOrDefault();

					if (word != null)
					{
						// sparar de nya orden i db
						word.Word1 = model.Word1;
						word.Word2 = model.Word2;
						db.SaveChanges();
					}
				}
				catch (Exception e)
				{
					// loggar eventuellt error
					logger.Error(e, "Unable to save in database");
				}
			}
			// skickar tillbaka användaren till föregående sida med rätt testId så man hamnar i rätt test
			return RedirectToAction("CreateWords", "Words", new { id = testId });
		}

		public ActionResult DeleteWord(int id)
		{
			int testId = 0;

			using (GlossaryModel db = new GlossaryModel())
			{
				try
				{
					Word word = (from w in db.Words
								 where w.Id == id   // jämför ordets id i db med samma id som skickades med som inparameter
								 select w).FirstOrDefault();

					if (word != null)
					{
						// raderar det valda ordet med rätt testId
						testId = word.TestId;
						db.Words.Remove(word);
						db.SaveChanges();
					}
				}
				catch (Exception e)
				{
					logger.Error(e, "Unable to save in database");
				}
			}
			return RedirectToAction("CreateWords", "Words", new { id = testId });
		}
	}
}
