/*
 * Created by SharpDevelop.
 * User: Carleson
 * Date: 2013-06-28
 * Time: 08:34
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace TextLib.Emails
{
	/// <summary>
	/// Description of Email.
	/// </summary>
	public class Email : TextLib.Text, IEmail
	{
		//private string _text;
		private List<string> _list = new List<string>();
		private List<MailAddress> _emails = new List<MailAddress>();
		
		
		public Email(string text)
		{
			base.Source=text;
			ExtractEmails();
			base.List = _list;
		}
		
#region Properties

		
	
		public IEnumerable<MailAddress> ListMailAddress
		{
			get {return _emails.AsEnumerable();}
		}
				
#endregion

#region Private methods
		private void ExtractEmails()
		    {
		        //instantiate with this pattern 
		        Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
		            RegexOptions.IgnoreCase);
		        //find items that matches with our pattern
		        MatchCollection emailMatches = emailRegex.Matches(base.Source);
		
		        foreach (Match emailMatch in emailMatches)
		        {
		        	_list.Add(emailMatch.Value);
		        	
		        	System.Net.Mail.MailAddress a = new System.Net.Mail.MailAddress(emailMatch.Value);
		        	_emails.Add(a);
		        }
		    }
#endregion

#region Public methods

		
#endregion

		

	}
}
