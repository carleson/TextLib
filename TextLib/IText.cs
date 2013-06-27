/*
 * Created by SharpDevelop.
 * User: a491259
 * Date: 2013-06-27
 * Time: 13:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

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
		
		int Count
	    {
	        get;
	    }
		
		int SizeInBytes
		{
			get;
		}
		
		void Sort();
		    
	}
}
