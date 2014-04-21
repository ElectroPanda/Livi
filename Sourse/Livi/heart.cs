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
		public kartochka[] heartarr=new kartochka[2];
		public string[] saPublicNames=new string[1];
		
		public void clonn (kartochka[] a)
		{
			Array.Resize(ref this.heartarr,a.Length);
			this.heartarr = (kartochka[])a.Clone();
			this.heartarr[0]=new kartochka();
	
			
		} //end clonn method
		
		public heart()
		{
			heartarr[1]=new kartochka();
			//Array.Resize(ref this.heartarr,a.Length);
			//kartochka[] heartarr = (kartochka[])a.Clone();
					
		}//end costruct
		
		public void printt()
		{
			//ConsoleAsisst.WriteLine(this.heartarr.Length+"++++++++");
			
			for (int i=1;i<this.heartarr.Length;i++)
			{
				this.heartarr[i].consoleprint();
				
			} //end for
		} //end printt method
	}//end class
}//end name space
