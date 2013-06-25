/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-06-25
 * Time: 16:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace TextLib
{
	/// <summary>
	/// Description of Number.
	/// </summary>
	public class Number
	{
		private string _text;
		
		public Number(TextLib.Textlib lib)
		{
			_text = lib.Text;
		}
		
		public int Count()
		{
            int numNumbers = 0;
            foreach (char c in _text)
            {
                if (char.IsNumber(c))
                    numNumbers ++;
            }
            
            return numNumbers;
		}
			
				
		public List<int> Numbers()
		{
			List<int> numberList = new List<int>();
			foreach (char c in _text)
            {
                if (char.IsNumber(c))
                	numberList.Add(c);
            }
			return numberList;
		}
	}
}
