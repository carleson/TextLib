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
	public class Word : TextLib.Textlib
	{
		
		public Word(string text)
		{
			Text = text;
		}

		
		public int Count(string word)
		{
			string text = Text;
			int pos = 0;
			int count = 0;
			pos = text.IndexOf(word);
			while (pos != -1 && text.Length >= pos)
			{
				count++;
				pos = Text.IndexOf(word,pos+1);
			}
			return count;
		}
		

		public int Count()
		{		
			string[] words = Text.Split(new string[] {" ", "\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
		}
		
		/// <summary>
		/// Calculates the true size of a string, in bytes
		/// </summary>
		/// <param name="input">String to get the size of</param>
		/// <returns></returns>
		public int GetSizeInBytes()
		{
			//X = (8 + 4 + 2 + (2 * LEN)) + 4 - 1) / 4 * 4
			int size = (8 + 4 + 2 + (2 * Text.Length)) + 4 - 1; // / 4 * 4;
			size = size/4 * 4;
			
			return size;
		}
		
		public List<string> Words()
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
	}
}
