/*
 * Created by SharpDevelop.
 * User: Carleson
 * Date: 2013-07-30
 * Time: 11:07
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace TextLib
{

	public interface INumbers
	{
		List<int> Numbers{get;}
		
		IEnumerable<int> Gt(int minValue);
		
		IEnumerable<int> Lt(int maxValue);
		
		void Sort();
	}
}
