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
	public class NumbersTest : Test.TestUtil
	{
		
		public NumbersTest()
		{
		}
		
		[SetUp]
		public void init()
		{
			_number = new Number(NumbersAndLetters);
		}
		
		[Test]
		public void GetNumbers()
		{
			Assert.IsTrue(_number.Numbers.Count==6);
		}
		
		[Test]
		public void GetZeroNumbers()
		{
			_number = new Number("abcd");
			Assert.IsTrue(_number.Numbers.Count==0);
		}
		
	}
}
