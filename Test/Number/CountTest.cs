﻿/*
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
	public class CountTest : Test.TestUtil
	{
		
		public CountTest()
		{
		}
		
		[SetUp]
		public void init()
		{
			_number = new Number(FiveNumbers);
		}

		[Test]
		public void CountNumbersAndLetters()
		{
			Assert.IsTrue(_number.Count == 5);
		}
		
	
	}
}
