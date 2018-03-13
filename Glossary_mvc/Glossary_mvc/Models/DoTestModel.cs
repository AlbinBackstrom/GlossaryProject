using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Glossary_mvc.Models
{
	public class DoTestModel
	{
		public string Word1 { get; set; }
		public string Word2 { get; set; }
		public List<Word> Words { get; set; }
		public List<string> mGuessedWord { get; set; }
		public List<Answers> Answers { get; set; }
	}

	public partial class Answers
	{
		public List<string> FacitWord1 { get; set; }
		public List<string> FacitWord2 { get; set; }
		public List<string> GuessedWrong { get; set; }
		public List<string> GueesedRight { get; set; }
		public int NumberOfTotalWords { get; set; }
		public int CorrectAnswers { get; set; }
		public int TestId { get; set; }
	}
}