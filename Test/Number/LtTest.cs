/*
 * Created by SharpDevelop.
 * User: carleson
 * Date: 2013-06-26
 * Time: 09:23
 */
using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using TextLib.Numbers;
using System.Diagnostics;

namespace NumberTest
{

	[TestFixture]
	public class LtTest : Test.TestUtil
	{	
		public LtTest()
		{
		}
		
		[SetUp]
		public void init()
		{
			_number = new Number(NumbersAndLetters);
			list= _number.Lt(4);	
		}

		[Test]
		public void GetTheRightElements()
		{
			Debug.Print(string.Format("{0}",list.Count()));
			Assert.IsTrue(list.Count() == 3,string.Format("Expected 1 but got:", list.Count()));
		}
		

		
	}
}
