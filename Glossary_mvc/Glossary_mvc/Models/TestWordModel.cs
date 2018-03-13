using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Glossary_mvc.Models
{
	public class TestWordModel
	{
		public int TestId { get; set; }
		public string Name { get; set; }
		public int MainLang { get; set; }
		public int SecLang { get; set; }
		public List<Word> Words { get; set; }
		public Word AddWord { get; set; }
		public string LangOne { get; set; }
		public string LangTwo { get; set; }
	}
}