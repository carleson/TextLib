/*
 * Created by SharpDevelop.
 * User: carleson
 * Date: 2013-06-25
 * Time: 16:02
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace TextLib.Numbers
{
	/// <summary>
	/// Description of Number.
	/// </summary>
	public class Number  : TextLib.Textlib
	{
		List<int> _numbers;
		
		public Number(string text)
		{
			Text=text;
			_numbers = GetNumbers();
		}
		
		public List<int> Numbers
		{
			get
			{
				return _numbers;
			}
		}
		
		public int Count
		{
			get
			{			
	            return Numbers.Count;
			}
		}
			
				
		private List<int> GetNumbers()
		{
			List<int> numberList = new List<int>();
			foreach (char c in Text)
            {
                if (char.IsNumber(c))
                {
                	int value = Int32.Parse(c.ToString());
                	numberList.Add(value);
                }
                	
            }
			return numberList;
		}
		
		public IEnumerable<int> Gt(int minValue)
		{		
			var bigNums = from n in Numbers
        	where n > minValue 
        	select n; 
			
			return bigNums;
		}
	
		public IEnumerable<int> Lt(int maxValue)
		{		
			var lowNums = from n in Numbers
        	where n < maxValue 
        	select n; 
			
			return lowNums;
		}		
	}
}
