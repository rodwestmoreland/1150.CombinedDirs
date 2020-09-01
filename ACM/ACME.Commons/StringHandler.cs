using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Commons
{
	public static class StringHandler
	{
		public static string InsertSpaces(string source)
		{
			var result = String.Empty;
			if (!string.IsNullOrWhiteSpace(source))
			{
				foreach (char letters in source)
				{
					if (char.IsUpper(letters))
					{ result += " "; }
					result += letters;
				}
				result = result.Remove(0, 1);
			}
			return result;
		} 
	}
}
