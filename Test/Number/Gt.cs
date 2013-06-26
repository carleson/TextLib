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
	public class Gt : Test.TestUtil
	{
		IEnumerable<int> list;
		
		public Gt()
		{
		}
		
		[SetUp]
		public void init()
		{
			_number = new Number("abc13lmn5890v");
			list= _number.Gt(5);	
		}

		[Test]
		public void GetTheRightElements()
		{
			Debug.Print(string.Format("{0}",list.Count()));
			Assert.IsTrue(list.Count() == 2);
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
