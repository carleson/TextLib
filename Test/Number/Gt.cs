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
using System.Linq;
using System.Collections.Generic;


namespace Test.Number
{

	[TestFixture]
	public class Gt:TestUtil
	{
		IEnumerable<int> list;
		
		public Gt()
		{
		}
		
		[SetUp]
		public void init()
		{
			lib.Load("abc13lmn5890v");
			list = lib.number.Gt(5);
		}

		[Test]
		public void GetTheRightElements()
		{
			Assert.IsTrue(list.Count() == 2);
		}
	}
}
