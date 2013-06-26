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
using TextLib.Numbers;
using System.Diagnostics;

namespace Test
{

	[TestFixture]
	public class Gt //:TestUtil
	{
		IEnumerable<int> list;
		Number nr;
		
		public Gt()
		{
		}
		
		[SetUp]
		public void init()
		{
			nr = new Number("abc13lmn5890v");
			list= nr.Gt(5);
//			
//			lib.Load("abc13lmn5890v");
//			list = lib.number.Gt(5);
			
		}

		[Test]
		public void GetTheRightElements()
		{
			Debug.Print(string.Format("{0}",list.Count()));
			Assert.IsTrue(list.Count() == 2);
		}
	}
}
