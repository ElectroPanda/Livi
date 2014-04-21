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
	public class kartochka //описывает объём текста отображаемый одномоментно
	{
		int iSerNumber; // Порядковый номер карточки
		public int iStartLineN; // Начало - номер строки с номером карточки
		int [] iaStartTime; //Начало экспозиции
		int [] iaEndTime; // Конец экспозиции
		string[] safulltext=new string[1]; //Массив строк карточки
		public string[] arrword=new string[1]; //Массив слов карточки
		
		public void consoleprint()
		{
			ConsoleAsisst.WriteLine();
			ConsoleAsisst.WriteLine("kartochka #"+this.iSerNumber+"  Nachalo v stroke #"+iStartLineN);
			
			for (int i=0;i<this.safulltext.Length;i++)
			{
				ConsoleAsisst.WriteLine(i+") "+this.safulltext[i]);
			}//end for
			
			for (int i=0;i<this.arrword.Length;i++)
			{
				ConsoleAsisst.WriteLine(" {"+i+"}_"+this.arrword[i]+"<");
			}//end for
          
		} // end consoleprint
		
		public kartochka()
		{
			this.iSerNumber=0;
			this.arrword[0]="";
			this.safulltext[0]="";
			
		} //end kartochka konstruktor
		
		public void setmethod(int i, int b)
		{
			this.iSerNumber=i;
			this.iStartLineN=b;
			
		} // end kartochka setmethod
		
		public void settext(string a) //Добавление строки к массиву строк карточки
		{
			Array.Resize(ref this.safulltext,this.safulltext.Length+1);
			this.safulltext[this.safulltext.Length-2]=a;
			
		}//end settext method
		
		public void minuslastline() // Удаление последней строчки массива строк (только если она пуста)
		{
			if (string.IsNullOrEmpty(this.safulltext[this.safulltext.Length-1])==true)
			{
			Array.Resize(ref this.safulltext, this.safulltext.Length-1);
			} //end if
			
		} // end minuslastline
		
		public void arrwordcreate() //Создание массива слов
		{
			int q=0;
			for(int i=0;i<=this.safulltext.Length-1;i++) //обход всех строк в карточке
			{
				
				Array.Resize(ref this.arrword,this.arrword.Length+1); //добавление ячейки в массив слов
				for(int a=0;a<=this.safulltext[i].Length-1;a++) //обход БУКВ в обрабатываемоей строке 
				{
												
					if ((this.safulltext[i][a]+"")==" ")  //если активная буква пробел
					{q++; //увеличиваем индекс слова
					Array.Resize(ref this.arrword,this.arrword.Length+1); //увеличиваем размер массива
					}//end then
					else
					{
						this.arrword[q]=this.arrword[q]+this.safulltext[i][a]; //прибавляем букву к слову
					} //end else
				}//end for
				q++;
				
				
			}//end for
			Array.Resize(ref this.arrword,this.arrword.Length-1);
		}//end arrwordcreate method
       
		public void copymethod(kartochka a)
		{
			this.iSerNumber=a.iSerNumber;
			this.iStartLineN=a.iStartLineN;
			
		} //end copy method

	} //end kartochka class
}// end name space
