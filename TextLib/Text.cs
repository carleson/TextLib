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
		
		public int SizeInBytes {
			get {
				throw new NotImplementedException();
			}
		}
		
//		public override void Sort()
//		{
//			throw new NotImplementedException();
//		}
		
//		public int Count()
//		{
//			return List.Count();
//		}
	}
}
