/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-06-27
 * Time: 15:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
	public class Web:TextLib.IText
	{
		private string _text;
		private List<string> _links = new List<string>();
		private IEnumerable<string> _list = new List<string>();
		
		public Web(string text)
		{
			if (text != null)
			{
				_text = text;
			}
			else
			{
				_text=string.Empty;
			}

			_links = GetLinks();
			
		}
		
#region Properties

		public string PlainText
		{
			get
			{
				HtmlToText html = new HtmlToText();
				return html.Convert(String);
			}
		}
		public List<string> Links
		{
			get
			{
				return _links;
			}
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
		        MatchCollection matches = IpadressRegex.Matches(String);
		
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
				
		public IEnumerable<string> List 
		{
			get {return _links.AsEnumerable();}
		}
				
		public string String {get;set;}
		
		public int SizeInBytes {
			get {
				throw new NotImplementedException();
			}
		}
#endregion
		
#region Private methods

private List<string> GetLinks()
{
	var links = String.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www."));
    foreach (string s in links)
    	_links.Add(s);
    return _links;
}

	#endregion

#region Public methods

		public int Count()
		{
			return _list.Count();
		}
		
		public void Sort()
		{
			throw new NotImplementedException();
		}
#endregion



		

	}
}
