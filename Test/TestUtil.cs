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
using TextLib;
using TextLib.Numbers;

namespace Test
{

	public class TestUtil
	{
		public int[] NumberArray {get;set;}
		public Textlib lib;
		public Number _number;
		
		public TestUtil()
		{
			lib = new Textlib();
			
			int[] _numberArray = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			NumberArray=_numberArray;
			
		}
	}
}
