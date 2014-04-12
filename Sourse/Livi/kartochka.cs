/*
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
		string[] arrword=new string[1];
		
		public void consoleprint()
		{
			//Console.WriteLine();
			//Console.WriteLine("kartochka #"+this.iSerNumber+"  Nachalo v stroke #"+iStartLineN);
			
			for (int i=0;i<this.safulltext.Length;i++)
			{
				//Console.WriteLine(i+") "+this.safulltext[i]);
			}//end for
			
			for (int i=0;i<this.arrword.Length;i++)
			{
				//Console.WriteLine(" {"+i+"} "+this.arrword[i]);
			}//end for
			
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
			this.safulltext[this.safulltext.Length-2]=a;
			//Array.Resize(ref this.safulltext,this.safulltext.Length-1);
		}//end settext method
		
		public void minuslastline()
		{
			if (string.IsNullOrEmpty(this.safulltext[this.safulltext.Length-1])==true)
			{
			Array.Resize(ref this.safulltext, this.safulltext.Length-1);
			} //end if
			
		} // end minuslastline
		
		public void arrwordcreate()
		{
			int q=0;
			for(int i=0;i<=this.safulltext.Length-1;i++)
			{
				//q++;
				Array.Resize(ref this.arrword,this.arrword.Length+1);
				for(int a=0;a<=this.safulltext[i].Length-1;a++)
				{
					
					//Console.WriteLine(this.safulltext[i][a]);
					
					if ((this.safulltext[i][a]+"")==" ")
					{q++;
					Array.Resize(ref this.arrword,this.arrword.Length+1);
					}//end then
					else
					{
						this.arrword[q]=this.arrword[q]+this.safulltext[i][a];
					} //end else
				}//end for
				q++;
				//Array.Resize(ref this.arrword,this.arrword.Length+1);
			
				
			}//end for
			Array.Resize(ref this.arrword,this.arrword.Length-1);
		}//end arrwordcreate method
	} //end kartochka class
}
