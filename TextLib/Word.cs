/*
 * Created by SharpDevelop.
 * User: carleson
 * Date: 2013-06-25
 * Time: 13:27
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace TextLib
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


		

		
		private List<string> GetWords()
		{
			string[] words = Text.Split(new string[] {" ", "\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);
			return words.ToList();
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

			 Console.WriteLine("Top three most common words: {0}, {1}, {2}", commonWords[0], commonWords[1], commonWords[2]);
			 string output = string.Format("Top three most common words: {0}, {1}, {2}", commonWords[0], commonWords[1], commonWords[2]);
			 return output;
		}
#region Properties	

		public string Text 
		{
			get { return _text;	}
		}
		
				public List<string> Words
		{
			get
			{
				return _words;
			}
		}
		
		public int Count
		{
			get
			{
				return _words.Count;
			}
		}
		
	
#endregion

#region Methods
	
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
		
#endregion

	}
}
