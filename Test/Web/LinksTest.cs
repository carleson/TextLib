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
using TextLib.Web;
using System.Diagnostics;

namespace WebTest
{

	[TestFixture]
	public class LinksTest : Test.TestUtil
	{	
		public LinksTest()
		{
		}
		
		[SetUp]
		public void init()
		{
			string web = "house home go www.monstermmorpg.com nice hospital http://www.monstermmorpg.com this is incorrect " +
						 "url http://www.monstermmorpg.commerged continue";
			_web = new Web(web);	
		}

		[Test]
		public void LinksReturnsCorrectLinks()
		{

			Assert.IsTrue(_web.Links().Count==3);
		}
		

		
	}
}
