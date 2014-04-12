/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 12.04.2014
 * Время: 21:14
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace Livi
{
	/// <summary>
	/// Description of karteacl.
	/// </summary>
	public class heart
	{
		kartochka[] heartarr=new kartochka[1];
		
		public heart(kartochka[] a)
		{
			Array.Resize(ref this.heartarr,a.Length);
			kartochka[] heartarr = (kartochka[])a.Clone();
			/*for (int i=1;i<=a.Length;i++)
			     {
			     	
			     } //end for*/
			
		}//end costruct
		
		public void printt()
		{
			Console.WriteLine(this.heartarr.Length+"++++++++");
		} //end printt method
	}//end class
}//end name space
