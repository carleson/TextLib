/*
 * Created by SharpDevelop.
 * User: carleson
 * Date: 2013-06-25
 * Time: 13:14
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
		public Letter letter {get; private set;}
		public Convert convert {get;private set;}
		public Number number {get;set;}
		
		public void Load(string text)
		{
			_text = text;
		}
		
		public Textlib()
		{
			Init();
		}
		
		public Textlib(string text)
		{
			_text = text;
			Init();
		}
		
		private void Init()
		{
			word = new Word(this);
			letter = new Letter(this);
			convert = new Convert(this);
			number = new Number();	
		}

		public string Text
		{
			get
			{
				if ( _text != null)
				{
					return _text;
				}
				else
				{
					return string.Empty;
				}
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