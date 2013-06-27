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
using TextLib.Words;
using System.Diagnostics;

namespace WordTest
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
			_word = new Word("banana apple orange banana");
		}

		[Test]
		public void CountIsCorrect()
		{
			//Assert.IsTrue(_word.
		}
		

		
	}
}
