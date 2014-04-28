/*
 * Сделано в SharpDevelop.
 * Пользователь: Илья
 * Дата: 28.04.2014
 * Время: 8:48
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Text.RegularExpressions;

namespace Livi
{
	/// <summary>
	/// Description of ArrayAsisst.
	/// </summary>
	public class ArrayAsisst
	{
		public ArrayAsisst()
		{
			//int a=0;
		}//end construtor method
		
		public static Boolean Havethisword (string[] a,string b)
		{
			Boolean c=false;
			for (int i=0; i<a.Length; i++)
			     {
			     	if(a[i]==b) {c=true;}
			     }//end for
			return c;
		} //end havethisword method
		
	} //end class
} //end namespace
