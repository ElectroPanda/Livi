﻿/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 06.04.2014
 * Время: 23:41
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Text.RegularExpressions;

namespace Livi
{
	/// <summary>
	/// Description of kartochka.
	/// </summary>
	public class kartochka
	{
		int iSerNumber;
		public int iStartLineN;
		int [] iaStartTime;
		int [] iaEndTime;
		string[] safulltext=new string[1];
		
		public void consoleprint()
		{
			Console.WriteLine();
			Console.WriteLine("kartochka #"+this.iSerNumber+"  Nachalo v stroke #"+iStartLineN);
			
			
		} // end consoleprint
		
		public kartochka()
		{
			this.iSerNumber=0;
			//this.safulltext[]=new string[1];
		} //end kartochka konstruktor
		
		public void setmethod(int i, int b)
		{
			this.iSerNumber=i;
			this.iStartLineN=b;
			
		} // end kartochka setmethod
		
		public void settext(string a)
		{
			Array.Resize(ref this.safulltext,this.safulltext.Length+1);
			this.safulltext[this.safulltext.Length]=a;
		}//end settext method
	} //end kartochka class
}
