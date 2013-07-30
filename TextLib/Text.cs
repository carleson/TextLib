/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-07-29
 * Time: 10:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
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
		
			
		public IEnumerable<string> List {get;set;}

		private string _source;
		
		public string Source 
		{
			get
			{ 
				return _source;
			}
			set
			{
				if (Source != null)
				{
					_source = Source;
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
			return new List<string>(List).Count;
		}
	}
}
