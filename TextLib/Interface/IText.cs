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
		
		List<string> List {get;set;}
		int SizeInBytes	{get;}
		
		//methods
		int Count();		
		int Count(string word);
		bool Exist(string value);
		    
	}
}
