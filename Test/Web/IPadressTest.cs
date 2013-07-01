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
	public class IpadressTest : Test.TestUtil
	{	
		public IpadressTest()
		{
		}
		
		[SetUp]
		public void init()
		{
			string web = "house home go www.monstermmorpg.com nice hospital http://www.monstermmorpg.com this is incorrect " +
						 "url http://www.monstermmorpg.commerged continue 192.168.0.122 www.idg.com bart@hotmail.com";
			_web = new Web(web);	
		}

		[Test]
		public void IpadressReturnsOneIPAdress()
		{

			Assert.IsTrue(_web.Ipadress().Count==1);
		}
		
		[Test]
		public void NoIpAdressesInText()
		{
			_web = new Web("here is some text");
			Assert.IsTrue(_web.Ipadress().Count == 0);
		}
	
		[Test]
		public void NoIpAdressesInEmptyText()
		{
			_web = new Web(null);
			Assert.IsTrue(_web.Ipadress().Count == 0);
		}
		
		[Test]
		public void HostnamesReturnsOneHostname()
		{
			_web = new Web("xxxx rr www.idg.com ");
			Assert.IsTrue(_web.HostNames().Count==1);
		}
		
		
	}
}
