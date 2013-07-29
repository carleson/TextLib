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
	public class Letter : TextLib.IText, ILetter
	{
		
		private  List<string> _letters;
		private IEnumerable<string> _list = new List<string>();
		
		private string _text;
		
		public Letter(string text)
		{
			if (text != null)
			{
				_text = text;
			}
			else
			{
				_text=string.Empty;
			}
			
			_letters = GetLetters();
			_list = _letters.AsEnumerable();
		}

#region Properties
		public string Text 
		{
			get {return _text;}
		}
		
				
		public IEnumerable<string> List 
		{
			get {return _list;}
		}
		
		public List<string> Letters
		{
			get
			{
				return _letters;
			}
		}
				
		public int SizeInBytes 
		{
			get {
				throw new NotImplementedException();
			}
		}		
		

#endregion

#region Private Methods
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
#endregion

#region Public Methods
		public void Sort()
		{
			List<string> lista = Letters;
			_letters = lista;
		}
		
		public int Count()
		{
			return _list.Count();
		}
		
#endregion



	}
}
