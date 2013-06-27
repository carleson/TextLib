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
	public class Number  : TextLib.IText
	{
		private List<int> _numbers;
		private string _text;
		
		public Number(string text)
		{
			if (text != null)
			{
				_text = text;
			}
			else
			{
				_text=string.Empty;
			}
			_numbers = GetNumbers();
		}
			
		
#region Properties
		public string Text 
		{
			get { return _text;	}
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
			
		
		public int SizeInBytes {
			get {
				throw new NotImplementedException();
			}
		}
	
#endregion

#region Private methods

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
