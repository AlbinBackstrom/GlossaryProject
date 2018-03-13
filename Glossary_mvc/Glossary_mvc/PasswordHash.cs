using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Glossary_mvc
{
	public class PasswordHash
	{
		// kod från: http://stackoverflow.com/questions/12416249/hashing-a-string-with-sha256

		public static string sha256(string password)
		{
			SHA256Managed crypt = new SHA256Managed();
			string hash = String.Empty;
			byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(password), 0, Encoding.ASCII.GetByteCount(password));
			foreach (byte theByte in crypto)
			{
				hash += theByte.ToString("x2");
			}
			return hash;
		}
	}
}