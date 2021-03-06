﻿/*
 * Created by SharpDevelop.
 * User: carleson
 * Date: 2013-06-25
 * Time: 13:27
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace TextLib.Words
{
	/// <summary>
	/// Description of Word.
	/// </summary>
	public class Word : TextLib.Text, IWord
	{
		private  List<string> _words;
		
		public Word(string text)
		{
			base.Source=text;
			base.List=GetWords();
		}

#region Properties	
					
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
			string[] words = base.Source.Split(new string[] {" ", "\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);
			return words.ToList();
		}

#endregion

#region Public methods
		
		public List<string> GetAllCaps()
		{
			List<string> hitList = new List<string>();
			string regexp = @"(\b[^\Wa-z0-9_]+\b)";
			MatchCollection matches = Regex.Matches(base.Source, regexp);
			foreach (Match MyMatche in matches)
	        {
	        	hitList.Add(MyMatche.Value);
	        }
					        
			return hitList;
		}
		
		public List<string> GetAllLowerCase()
		{
			string regexp = @"(\b[^\WA-Z0-9_]+\b)";
			List<string> hitList = new List<string>();
			MatchCollection matches = Regex.Matches(base.Source, regexp);
						foreach (Match MyMatche in matches)
	        {
	        	hitList.Add(MyMatche.Value);
	        }
			return hitList;
		}

		public List<string> GetAllInitialCaps()
		{
			string regexp = @"(\b[^\Wa-z0-9_][^\WA-Z0-9_]*\b)";
			List<string> hitList = new List<string>();
			MatchCollection matches = Regex.Matches(base.Source, regexp);
			foreach (Match MyMatche in matches)
	        {
	        	hitList.Add(MyMatche.Value);
	        }
			return hitList;
		}		
		
		public string CommonWords()
		{
			string[] words = base.Source.Split(new string[] {" ", "\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);

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
