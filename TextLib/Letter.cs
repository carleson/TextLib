/*
 * Created by SharpDevelop.
 * User: carleson
 * Date: 2013-06-25
 * Time: 13:33
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace TextLib.Letters
{
	/// <summary>
	/// Description of Char.
	/// </summary>
	public class Letter : TextLib.Textlib
	{
		
		private  List<string> _letters;
		
		public Letter(string text)
		{
			Text = text;
			_letters = GetLetters();
		}
		
		public List<string> Letters
		{
			get
			{
				return _letters;
			}
		}
		
		public int Count
		{
			get
			{
	            return _letters.Count;
			}
			
		}
						
		private List<string> GetLetters()
		{
			List<string> letterList = new List<string>();
			foreach (char c in Text)
            {
                if (char.IsLetter(c))
                	letterList.Add(c.ToString());
            }
			return letterList;
		}

	}
}
