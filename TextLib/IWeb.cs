/*
 * Created by SharpDevelop.
 * User: Carleson
 * Date: 2013-07-30
 * Time: 11:31
 */
using System;
using System.Collections.Generic;

namespace TextLib
{
	/// <summary>
	/// Description of IWeb.
	/// </summary>
	public interface IWeb
	{
		
		string PlainText{get;}
		
		List<string> Links();
		List<string> Email();
		List<string> HostNames();
		List<string> Ipadress();
			
			
	}
}
