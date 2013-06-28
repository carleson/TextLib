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
using System.Diagnostics;
using TextLib.Emails;

namespace EmailTest
{

	[TestFixture]
	public class EmailTest : Test.TestUtil
	{
		
		public EmailTest()
		{
		}
		
		[SetUp]
		public void init()
		{
			_email = new Email(OneEmail);
		}

		[Test]
		public void CountOneEmail()
		{
			Assert.IsTrue(_email.Count() == 1);
		}
		
		[Test]
		public void CountZeroLetters()
		{
			_email = new Email(NumbersAndLetters);
			Assert.IsTrue(_email.Count() == 0);
		}
	
		[Test]
		public void CountNullEmails()
		{
			_email = new Email(null);
			Assert.IsTrue(_email.Count() == 0);
		}
		
	
	}
}
