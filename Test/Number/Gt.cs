/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-06-26
 * Time: 09:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Test.Number
{

	[TestFixture]
	public class Gt:TestUtil
	{
		public Gt()
		{
		}
		
		[SetUp]
		public void init()
		{
			lib.Load("test");
		}

		[Test]
		public void test1()
		{
			string actual = "John Roe Doe";
            string expected = "John Roe Doe";
            Assert.AreEqual(expected, actual, "The GetFullName returned a different Value");
		}
	}
}
