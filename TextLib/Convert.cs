/*
 * Created by SharpDevelop.
 * User: carleson
 * Date: 2013-06-25
 * Time: 14:28
 */
using System;

namespace TextLib
{
	/// <summary>
	/// Description of Convert.
	/// </summary>
	public class Convert : TextLib.Textlib
	{
		public Convert(string text)
		{
			Text = text;
		}
		
		public string ToHelloWorld
		{
			get
			{
				return "HelloWorld";
			}
		}
		
	}
}
