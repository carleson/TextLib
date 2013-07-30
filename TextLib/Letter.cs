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
	public class Letter : TextLib.Text, ILetter
	{
		
		private  List<string> _letters;
		
		public Letter(string text)
		{
			base.Source = text;
			_letters = GetLetters();
			List = _letters.AsEnumerable();
		}

#region Properties
		
		public List<string> Letters
		{
			get
			{
				return _letters;
			}
		}


#endregion

#region Private Methods
		private List<string> GetLetters()
		{
			List<string> letterList = new List<string>();
			foreach (char c in Source)
            {
                if (char.IsLetter(c))
                	letterList.Add(c.ToString());
            }
			return letterList;
		}
#endregion

#region Public Methods

		public void Sort()
		{
			List<string> lista = Letters;
			_letters = lista;
		}
		
		public int Count()
		{
			return List.Count();
		}
			
#endregion




	}
}
