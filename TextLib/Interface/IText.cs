/*
 * Created by SharpDevelop.
 * User: Carleson
 * Date: 2013-06-27
 * Time: 13:22
 */
using System;
using System.Collections.Generic;

namespace TextLib
{

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
