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
				return html.Convert(Text);
			}
		}
		public List<string> Links
		{
			get
			{
				return _links;
			}
		}
		
		public IEnumerable<string> List 
		{
			get {return _links.AsEnumerable();}
		}
				
		public string Text 
		{
			get {return _text;}
		}
		
		public int SizeInBytes {
			get {
				throw new NotImplementedException();
			}
		}
#endregion
		
#region Private methods

private List<string> GetLinks()
{
	var links = Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www."));
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
