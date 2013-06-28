/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-06-27
 * Time: 13:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace TextLib
{
	/// <summary>
	/// Description of IText.
	/// </summary>
	public interface IText
	{
		string Text
		{
			get;
		}
	
		IEnumerable<string> List
		{
			get;
		}
		
		int SizeInBytes
		{
			get;
		}
		
		void Sort();
		
		int Count();
		
		    
	}
}
