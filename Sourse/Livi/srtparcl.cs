/*
 * Сделано в SharpDevelop.
 * Пользователь: Илья
 * Дата: 07.04.2014
 * Время: 21:29
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Text.RegularExpressions;

namespace Livi
{
	/// <summary>
	/// Description of srtparcl.
	/// </summary>
	public class srtparcl
	{
		public heart brain=new heart();     
		public void srtpar(string[] instar)
	{
	
		int i;
		int a;
		string patternA=@"([-]{2,})([>]{1,})"; //Образец строки -->
		i=0;
        a=0;
                
		  
		Regex gex =new Regex(patternA);
						
		//Подсчёт карточек в файле
		for (i=0;i<instar.Length;i++) //Обход всех строк
		{
			
			if (string.IsNullOrEmpty(instar[i])==false) //Если строка НЕ пуста и НЕ является пробелом 
			{
				Match sochi = gex.Match(instar[i]);  //Проверка строки
				if (sochi.Success)//Если в строке встречается паттерн 
				{
					a++; //Увеличиваем счётчик на единицу					
				} //end if
				
			}// end if
		} //end for
					
		kartochka[] karar=new kartochka[a+1]; //Создание массива карточек соответствующей длинны
		
		a=0; //Обнуление счётчика
			
     //Создание массива карточек			
	 for (i=0;i<instar.Length;i++) //Обход всех строк
		{
			
	 	if (string.IsNullOrEmpty(instar[i])==false) //Если строка НЕ пуста и НЕ является пробелом 
			{
				Match sochi = gex.Match(instar[i]);//Проверка строки
				if (sochi.Success)//Если в строке встречается паттерн 
				{
					a++; //Увеличиваевм счётчик 
					karar[a]=new kartochka(); //Создание нового объекта карточки
					karar[a].setmethod(Convert.ToInt32(instar[i-1]),i-1); //Задание первого номера и первой строки
			       
				} //end if
				
			}// end if
		} //end for
	   
	//Заполнение массива строк в каждом из объектов карточек КРОМЕ ПОСЛЕДНЕЙ
   for (a=1;a<karar.Length-1;a++) //обход массива карточек
   {
   	for (i=(karar[a].iStartLineN+2);i!=(karar[a+1].iStartLineN-1);i++) //обход строк с текстом
   	{
   		karar[a].settext(instar[i]); //добавление строки  к массиву
   		
   	} //end for
   	karar[a].minuslastline();
   	karar[a].arrwordcreate();
   	karar[a].consoleprint();
   }//end for
	
	//Заполнение массива строк в последней карточке
   for (i=(karar[karar.Length-1].iStartLineN+2);i!=(instar.Length);i++)
   {
   	karar[karar.Length-1].settext(instar[i]);
   	
   }// end for
   
   karar[karar.Length-1].minuslastline();
   karar[karar.Length-1].arrwordcreate();
   karar[karar.Length-1].consoleprint();
      
   this.brain.clonn(karar);
   this.brain.printt();
   
   
	 } //end srtpar method
		
		public heart returnheart()
		{
			
			return this.brain;
		}
	}// end srtparccl class 
}//end name space


