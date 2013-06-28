/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-06-28
 * Time: 08:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TextLib.Emails
{
	/// <summary>
	/// Description of Email.
	/// </summary>
	public class Email : IText
	{
		private string _text;
		private List<string> _emails = new List<string>();
		
		
		public Email(string text)
		{
			if (text != null)
			{
				_text = text;
			}
			else
			{
				_text=string.Empty;
			}
			ExtractEmails();
		}
		
#region Properties

		public string Text 
		{
			get {return _text;}
		}
		
		public int Count 
		{
			get {return _emails.Count();}
		}
		
		public int SizeInBytes {
			get {
				throw new NotImplementedException();
			}
		}
		
		public IEnumerable<string> List 
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
		        MatchCollection emailMatches = emailRegex.Matches(Text);
		
		        foreach (Match emailMatch in emailMatches)
		        {
		        	_emails.Add(emailMatch.Value);
		        }
		    }
#endregion
		public void Sort()
		{
			//return List.OrderByDescending();
		}
		

	}
}
