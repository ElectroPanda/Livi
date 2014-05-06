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
         
		public static void ReadKey()
		{
			Console.ReadKey();
			
		} //end waitt method
		
			
		public static void Write(string a)
		{
			Console.Write(a);
		} // end printline method
		
		public static void WriteLine (string a)
		{
			Console.WriteLine(a); 
			
		} //end printline twoarg version method
		
		//*******************************************************************
		//Перегрузки перегрузочки
		
		public static void Write()
		{
			ConsoleAsisst.Write("");
		} //argumentless reload write method
		
		public static void WriteLine()
		{
			ConsoleAsisst.WriteLine("");
		} //argument less reload WriteLine method
		
		public ConsoleAsisst()
		{
			i=i+1;
		} //end class constuctor
		
		public static void ConsoleTimePrint()
		{
			ConsoleAsisst.Write(DateTime.Now.Hour.ToString()+":"DateTime.Now.Minute.ToString()+":"+DateTime.Now.Second.ToString()+","+DateTime.Now.Millisecond.ToString());
			//ConsoleAsisst.Write(DateTime.Now.Minute.ToString()+":");
			//ConsoleAsisst.Write(DateTime.Now.Second.ToString()+",");
			//ConsoleAsisst.Write(DateTime.Now.Millisecond.ToString()+"  ");
			ConsoleAsisst.Write("Нажмите любую клавишу");
			//ConsoleAsisst.ReadKey();
			
		} //end console 
		
	} //end class ConsoleAsisst 
} //end anmespace Livi
