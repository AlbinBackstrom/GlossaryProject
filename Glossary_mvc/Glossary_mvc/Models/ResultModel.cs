using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Glossary_mvc.Models
{
	public class ResultModel
	{
		public int TestId { get; set; }
		public int CorrectGuessedWords { get; set; }
		public int TotalNumberWords { get; set; }
		public DateTime DateOfTest { get; set; }
		public string NameOfTest { get; set; }
		public int OriginalLanguage { get; set; }
		public int TranslationLanguage { get; set; }
	}
}