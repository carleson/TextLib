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
		//public string Text;
		
		public Number(string text)
		{
			Text=text;
		}
		
		public int Count()
		{
            int numNumbers = 0;
            foreach (char c in Text)
            {
                if (char.IsNumber(c))
                    numNumbers ++;
            }
            
            return numNumbers;
		}
			
				
		public List<int> Numbers
		{
			get
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
