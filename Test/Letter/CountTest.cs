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
using TextLib.Letters;
using System.Diagnostics;

namespace LetterTest
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
			_letter = new Letter(FiveLetters);
		}

		[Test]
		public void CountLetters()
		{
			Assert.IsTrue(_letter.Count() == 5);
		}
		
		[Test]
		public void CountNumbersAndLetters()
		{
			_letter = new Letter(NumbersAndLetters);
			Assert.IsTrue(_letter.Count() == 7);
		}
		
		[Test]
		public void CountZeroLetters()
		{
			_letter = new Letter("123");
			Assert.IsTrue(_letter.Count() == 0);
		}
	
		[Test]
		public void CountNullLetters()
		{
			_letter = new Letter(null);
			Assert.IsTrue(_letter.Count() == 0);
		}
		
	
	}
}
