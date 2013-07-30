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
	public class Number  : TextLib.Text
	{
		private List<int> _numbers;
		
		public Number(string text)
		{
			_numbers = GetNumbersAsIntegerList();
			List = GetNumbersAsStringList();
		}
			
		
#region Properties
			
		public List<int> Numbers
		{
			get
			{
				return _numbers;
			}
		}
			

#endregion

#region Private methods

		private List<int> GetNumbersAsIntegerList()
		{
			List<int> numberList = new List<int>();
			foreach (char c in Source)
            {
                if (char.IsNumber(c))
                {
                	int value = Int32.Parse(c.ToString());
                	numberList.Add(value);
                }
                	
            }
			return numberList;
		}
		
		private IEnumerable<string> GetNumbersAsStringList()
		{
			List<string> numberList = new List<string>();
			foreach (char c in Source)
            {
                if (char.IsNumber(c))
                {
                	numberList.Add(c.ToString());
                }
                	
            }
			return numberList.AsEnumerable();
		}
				
#endregion

#region Public methods
	
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
		
		public void Sort()
		{
			throw new NotImplementedException();
		}
#endregion


	}
}
