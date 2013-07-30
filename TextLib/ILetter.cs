/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-07-29
 * Time: 09:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace TextLib
{
	/// <summary>
	/// Description of ILetter.
	/// </summary>
	public interface ILetter
	{

		List<string> Letters{get;}
			
		void Sort();
		int Count();
		
	}
}
