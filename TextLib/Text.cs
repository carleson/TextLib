/*
 * Created by SharpDevelop.
 * User: Carleson
 * Date: 2013-07-29
 * Time: 10:23
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace TextLib
{
	/// <summary>
	/// Description of Text.
	/// </summary>
	public class Text : IText
	{
		public Text()
		{
		}
		
			
		public List<string> List {get;set;}

		private string _source;
		
		public string Source 
		{
			get
			{ 
				return _source;
			}
			set
			{
				if (value != null)
				{
					_source = value;
				}
				else
				{
					_source=string.Empty;
				}
			}
			
		}
		
		public int SizeInBytes
		{
			get
			{
				int size = (8 + 4 + 2 + (2 * Source.Length)) + 4 - 1; 
				size = size/4 * 4;
				
				return size;
			}
		}

		public int Count()
		{
			return List.Count;
		}
		
					
		public int Count(string word)
		{
			int hits = (from w in List where w == word select w).Count();
			return hits;	
		}
		
		public bool Exist(string value)
		{
			return List.Any(s => s.Contains(value));
		}
		
	}
}
