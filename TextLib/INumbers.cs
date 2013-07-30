/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-07-30
 * Time: 11:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace TextLib
{
	/// <summary>
	/// Description of INumbers.
	/// </summary>
	public interface INumbers
	{
		List<int> Numbers{get;}
		
		IEnumerable<int> Gt(int minValue);
		
		IEnumerable<int> Lt(int maxValue);
		
		void Sort();
	}
}
