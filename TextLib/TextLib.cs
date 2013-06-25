/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-06-25
 * Time: 13:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace TextLib
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class Textlib
	{
	
		private string _text;
		public Word word {get; private set;}
		public Character character {get; private set;}
		public Convert convert {get;private set;}
		
		public void Load(string text)
		{
			_text = text;
		}
		
		public Textlib(string text)
		{
			_text = text;
			word = new Word(this);
			character = new Character(this);
			convert = new Convert(this);
		}
		
		public string Text
		{
			get
			{
				return _text;
			}
		}
		
		public int Length
		{
			get
			{
				return _text.Length;
			}
		}
		
		public int SizeInBytes
		{
			get
			{
				int size = (8 + 4 + 2 + (2 * _text.Length)) + 4 - 1;
				size = size/4 * 4;
				return size;
			}
		}
				
	}
}