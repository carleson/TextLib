/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-06-25
 * Time: 13:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TextLib
{
	/// <summary>
	/// Description of Char.
	/// </summary>
	public class Character
	{
		private string _text;
		
		public Character(TextLib.Textlib lib)
		{
			_text = lib.Text;
		}
		
		public int Count()
		{
			return _text.Length;
		}
	}
}
