/*
 * Created by SharpDevelop.
 * User: carleson
 * Date: 2013-06-25
 * Time: 13:27
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace TextLib.Words
{
	/// <summary>
	/// Description of Word.
	/// </summary>
	public class Word : TextLib.IText
	{
		private  List<string> _words;
		private string _text;
		
		public Word(string text)
		{
			if (text != null)
			{
				_text = text;
			}
			else
			{
				_text=string.Empty;
			}
			
			_words=GetWords();
		}

#region Properties	

		public string Text 
		{
			get { return _text;	}
		}
		
		public IEnumerable<string> List 
		{
			get {return _words.AsEnumerable();}
		}
					
		public List<string> Words
		{
			get
			{
				return _words;
			}
		}
		

#endregion

#region Private methods

		private List<string> GetWords()
		{
			string[] words = Text.Split(new string[] {" ", "\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);
			return words.ToList();
		}

#endregion

#region Public methods
	
		public bool Exists(string value)
		{
			return _words.Any(s => s.Contains(value));
		}
		
		public int Count()
		{
			return _words.Count();
		}
				
		public int Count(string word)
		{
			int hits = (from w in _words where w == word select w).Count();
			return hits;	
		}
		
		public void Sort()
		{
			throw new NotImplementedException();
		}
		
		public int SizeInBytes
		{
			get
			{
				int size = (8 + 4 + 2 + (2 * Text.Length)) + 4 - 1; 
				size = size/4 * 4;
				
				return size;
			}
		}
		
		public string CommonWords()
		{
			string[] words = Text.Split(new string[] {" ", "\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);

            // Most common words
            var dictionary = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

            foreach (string word in words)
            {
                if (dictionary.ContainsKey(word))
                    dictionary[word] = dictionary[word] + 1;
                else
                    dictionary[word] = 1;
            }

            var sortedDictionary = from item in dictionary
                              orderby item.Value descending
                              select item;

            string[] commonWords = new string[3];
            int count = 0;

            foreach (KeyValuePair<string, int> item in sortedDictionary.Take(3))
            {
                commonWords[count] = item.Key;
                count++;
            }

			 string output = string.Format("Top three most common words: {0}, {1}, {2}", commonWords[0], commonWords[1], commonWords[2]);
			 return output;
		}
		
#endregion

		


	}
}
