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
	public class GtTest : Test.TestUtil
	{
		
		public GtTest()
		{
		}
		
		[SetUp]
		public void init()
		{
			_number = new Number(NumbersAndLetters);
			list= _number.Gt(5);	
		}

		[Test]
		public void GetTheRightElements()
		{
			Debug.Print(string.Format("{0}",list.Count()));
			Assert.IsTrue(list.Count() == 2);
		}
		
	
	}
}
