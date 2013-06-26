/*
 * Created by SharpDevelop.
 * User: carleson
 * Date: 2013-06-25
 * Time: 13:33
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace TextLib
{
	/// <summary>
	/// Description of Char.
	/// </summary>
	public class Letter
	{
		private string _text;
		
		public Letter(TextLib.Textlib lib)
		{
			_text = lib.Text;
		}
		
		public int Count()
		{
			string text = _text;

            int numLetters = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                    numLetters ++;
            }
            return numLetters;
		}
						
		public List<string> Letters()
		{
			List<string> letterList = new List<string>();
			foreach (char c in _text)
            {
                if (char.IsLetter(c))
                	letterList.Add(c.ToString());
            }
			return letterList;
		}

	}
}
