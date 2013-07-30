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
		
		//Properties
		string Source {get;set;}
		
		IEnumerable<string> List {get;set;}
		
		//methods
		int SizeInBytes
		{
			get;
		}
		
	
		    
	}
}
