/*
 * Created by SharpDevelop.
 * User: Carleson
 * Date: 2013-07-30
 * Time: 11:41
 */
using System;
using System.Collections.Generic;

namespace TextLib
{
	public interface IWord
	{
		List<string> GetAllCaps();
		List<string> GetAllLowerCase();
		List<string> GetAllInitialCaps();
		string CommonWords();
	}
}
