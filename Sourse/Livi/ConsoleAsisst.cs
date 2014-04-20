/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 20.04.2014
 * Время: 23:07
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace Livi
{
	/// <summary>
	/// Description of ConsoleAsisst.
	/// </summary>
	public class ConsoleAsisst
	{
		private int i;
		
		public ConsoleAsisst()
		{
			i=i+1;
		} //end class constuctor
		
		public static void ConsoleTimePrint()
		{
			Console.Write(DateTime.Now.Hour.ToString()+":");
			Console.Write(DateTime.Now.Minute.ToString()+":");
			Console.Write(DateTime.Now.Second.ToString()+",");
			Console.Write(DateTime.Now.Millisecond.ToString()+"  ");
			
		} //end console 
		
	} //end class ConsoleAsisst 
} //end anmespace Livi
