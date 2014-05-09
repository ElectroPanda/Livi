/*
 * Сделано в SharpDevelop.

 */
using System;
using System.Text.RegularExpressions;

namespace Livi
{
	/// <summary>
	/// Description of WordAsisst.
	/// </summary>
	public class WordAsisst
	{
		
		public WordAsisst()
		{
		} //end constructor
		
		public static Boolean HaveCapetalLetter (string a)
		{
			Boolean b;
			string patternA=@"([A-Z]{1,})";  //([-]{2,})([>]{1,})
			Regex gex = new Regex(patternA);
			//Match yalta =gex.Match(instar[i-1]);
				//sudno=yalta.Success;
			Match glic = gex.Match(a);
 			b=glic.Success;
			return b;
		} // End HaveCapetalLetter method
		
		
		public static Boolean HaveDot (string a)
		{
			Boolean b;
			string patternA=@"([!?.]{1,})";  //([-]{2,})([>]{1,})
			Regex gex = new Regex(patternA);
			//Match yalta =gex.Match(instar[i-1]);
				//sudno=yalta.Success;
			Match glic = gex.Match(a);
 			b=glic.Success;
			return b;
		} // End HaveDot method
		
				
		public static Boolean HaveComma (string a)
		{
			Boolean b;
			string patternA=@"([,]{1,})";  //([-]{2,})([>]{1,})
			Regex gex = new Regex(patternA);
			//Match yalta =gex.Match(instar[i-1]);
				//sudno=yalta.Success;
			Match glic = gex.Match(a);
 			b=glic.Success;
			return b;
		} // End HaveComma method
		
		public static string klacklac(string a)
		{
			while (WordAsisst.HaveDot(a))
			{
				a=a.Substring(0,a.Length-1);
			} //end for
			
			while (WordAsisst.HaveComma(a))
			{
				a=a.Substring(0,a.Length-1);
			} //end for
			
			return a;
		} // end klacklac method
		
		
	} // end WordAsiss class 
} //end name space Livi
