/*
 * Created by SharpDevelop.
 * User: Carleson
 * Date: 2013-06-27
 * Time: 15:11
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TextLib.Web
{
	/// <summary>
	/// Description of Url.
	/// </summary>
	public class Web: TextLib.Text, IWeb
	{
		private List<string> _links = new List<string>();
		
		public Web(string text)
		{
			base.Source = text;
			base.List =GetLinks().AsEnumerable();
		}
		
#region Properties

		public string PlainText
		{
			get
			{
				HtmlToText html = new HtmlToText();
				return html.Convert(base.Source);
			}
		}
		
		public List<string> Links()
		{
			return GetLinks();
		}
		
		public List<string> Email()
		{
			string emailPattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
			return RegExpList(emailPattern);
		}
		public List<string> HostNames()
		{
			string hostNamePattern = @"^[\-\w]+\.)+[a-zA-Z]{2,4}$";
			return RegExpList(hostNamePattern);
		}
		public List<string> Ipadress()
		{
			string ipadressPattern = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";
			return RegExpList(ipadressPattern);
		}
		
		public List<string> RegExpList(string reg)
		{
			List<string> regexpList = new List<string>();
			
			try
			{
		        Regex IpadressRegex = new Regex(reg,RegexOptions.IgnoreCase);
		        //find items that matche@s with our pattern
		        MatchCollection matches = IpadressRegex.Matches(base.Source);
		
		        foreach (Match MyMatche in matches)
		        {
		        	regexpList.Add(MyMatche.Value);
		        }
		        return regexpList;
			}
			   
			catch(Exception ex)
			{
				return null;
			}
		    
			//^([0-2]?[0-5]?[0-5]\.){3}[0-2]?[0-5]?[0-5]$
		}
				


#endregion
		
#region Private methods

private List<string> GetLinks()
{
	var links = base.Source.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www."));
    foreach (string s in links)
    	_links.Add(s);
    return _links;
}

	#endregion

#region Public methods


#endregion



		

	}
}
