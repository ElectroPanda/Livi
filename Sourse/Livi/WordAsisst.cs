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
			Char[] Signnn={'.',',','!','?','`',' ','*'};
			a=a.TrimEnd(Signnn); //Ускорение на треть!!!!!! На треть!!!
			return a;
		} // end klacklac method
		
		
	} // end WordAsiss class 
} //end name space Livi
