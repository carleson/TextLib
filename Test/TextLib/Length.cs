/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-06-26
 * Time: 11:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Test.TextLib
{

	[TestFixture]
	public class Length:TestUtil
	{
		private string my_String = "0123456789";
		
		public Length()
		{
		}
		
		[SetUp]
		public void setup()
		{
			lib.Load(my_String);
		}
		
		[Test]
		public void GetTheRightSize()
		{
			Assert.IsTrue(my_String.Length == lib.Length);	
		}
		
		[Test]
		public void EmptyStringWillNotFail()
		{
			lib.Load(string.Empty);
			Assert.IsTrue(lib.Length == 0);	
		}
	}
}
