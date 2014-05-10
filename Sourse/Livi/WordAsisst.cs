/*
 * Сделано в SharpDevelop.
 * Пользователь: Илья
 * Дата: 21.04.2014
 * Время: 7:27
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
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
			Boolean b=false;
			/*
			string patternA=@"([!?.]{1,})";  //([-]{2,})([>]{1,})
			Regex gex = new Regex(patternA);
			//Match yalta =gex.Match(instar[i-1]);
				//sudno=yalta.Success;
			Match glic = gex.Match(a);
 			b=glic.Success;
 			*/
 			string voskl="!";
 			string vopr="?";
 			string dooot=".";
 			int i=a.IndexOf(voskl)+a.IndexOf(vopr)+a.IndexOf(dooot);
 			if (i>=0) {b=true;}
			return b;
			//прироста скорости нет - но код минимализирован
		} // End HaveDot method
		
				
		public static Boolean HaveComma (string a)
		{
			Boolean b=false;
			/*
			string patternA=@"([,]{1,})";  //([-]{2,})([>]{1,})
			Regex gex = new Regex(patternA);
			//Match yalta =gex.Match(instar[i-1]);
				//sudno=yalta.Success;
			Match glic = gex.Match(a);
 			b=glic.Success;
 			*/
 			string commma=",";
 			int i=a.IndexOf(commma);
 			if (i>=0) {b=true;}
			return b;
			//прироста скорости нет - но код минимализирован
		} // End HaveComma method
		
		public static string klacklac(string a)
		{
			Char[] Signnn={'.',',','!','?','`',' ','*'};
			a=a.TrimEnd(Signnn); //Ускорение на треть!!!!!! На треть!!!
			return a;
		} // end klacklac method
		
		
	} // end WordAsiss class 
} //end name space Livi
