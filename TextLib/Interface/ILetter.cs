/*
 * Created by SharpDevelop.
 * User: Carleson
 * Date: 2013-07-29
 * Time: 09:29
 */
using System;
using System.Collections.Generic;

namespace TextLib
{
	public interface ILetter
	{

		List<string> Letters{get;}
			
		void Sort();
		int Count();
		
	}
}
