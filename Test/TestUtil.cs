/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-06-26
 * Time: 09:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using TextLib.Numbers;
using TextLib.Letters;
using TextLib.Words;
using TextLib.Web;
using TextLib.Emails;

namespace Test
{

	public class TestUtil
	{
		public int[] NumberArray {get;set;}
		public Number _number;
		public Letter _letter;
		public Word	_word;
		public Web _web;
		public Email _email;
		
		public const string NumbersAndLetters = "abc13lmn5890v";
		public const string FiveNumbers = "adrw579dert19";
		public const string FiveLetters = "ad579der19";
		public const string OneEmail = "qwert bart@hotmail.com some text";
		
		public IEnumerable<int> list;
		
		public TestUtil()
		{
			
			int[] _numberArray = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			NumberArray=_numberArray;
			
		}
	}
}
