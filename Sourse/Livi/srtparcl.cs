/*
 * Сделано в SharpDevelop.
 * Пользователь: Илья
 * Дата: 17.04.2014
 * Гитхаб-сука-сука
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
		string patternB=@"([:]{1,})";//Любая цифра хоть одна из всех безвыходных ситуаций
>>>>>>> 99ad7e43d0da0727391dd1dfb5aafbaf30a8cb75
=======
		string patternB=@"([:]{1,})";//Любая цифра хоть одна из всех безвыходных ситуаций
>>>>>>> 99ad7e43d0da0727391dd1dfb5aafbaf30a8cb75
=======
>>>>>>> parent of 51f6a82... Попытки-попыточки
=======
>>>>>>> parent of 51f6a82... Попытки-попыточки
=======
>>>>>>> parent of 51f6a82... Попытки-попыточки
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
				if (sochi.Success)//Если в строке встречается паттерн 
=======
				Boolean kiiv=true;  if (i>1) {Match kiev=xeg.Match(instar[i-1]); kiiv=kiev.Success;}
				Boolean leparis=true; if(i>1){Match paris =gex.Match(instar[i-1]);leparis=paris.Success;}
				if ((sochi.Success))//Если в строке встречается паттерн
>>>>>>> 99ad7e43d0da0727391dd1dfb5aafbaf30a8cb75
=======
				Boolean kiiv=true;  if (i>1) {Match kiev=xeg.Match(instar[i-1]); kiiv=kiev.Success;}
				Boolean leparis=true; if(i>1){Match paris =gex.Match(instar[i-1]);leparis=paris.Success;}
				if ((sochi.Success))//Если в строке встречается паттерн
>>>>>>> 99ad7e43d0da0727391dd1dfb5aafbaf30a8cb75
=======
				if (sochi.Success)//Если в строке встречается паттерн 
>>>>>>> parent of 51f6a82... Попытки-попыточки
=======
				if (sochi.Success)//Если в строке встречается паттерн 
>>>>>>> parent of 51f6a82... Попытки-попыточки
=======
				if (sochi.Success)//Если в строке встречается паттерн 
>>>>>>> parent of 51f6a82... Попытки-попыточки
				{
					if (kiiv==false)
					{
					a++; //Увеличиваевм счётчик 
					karar[a]=new kartochka(); //Создание нового объекта карточки
					karar[a].setmethod(Convert.ToInt32(instar[i-1]),i-1); //Задание первого номера и первой строки
					}
				} //end if
				
			}// end if
		} //end for
	   
	//Заполнение массива строк в каждом из объектов карточек КРОМЕ ПОСЛЕДНЕЙ
   for (a=1;a<karar.Length-2;a++) //обход массива карточек
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
   for (i=(karar[karar.Length-2].iStartLineN+2);i!=(instar.Length);i++)
   {
   	karar[karar.Length-2].settext(instar[i]);
   	
   }// end for
   
<<<<<<< HEAD
   karar[karar.Length-2].minuslastline();
   karar[karar.Length-2].arrwordcreate();
=======
   karar[karar.Length-1].minuslastline();
   karar[karar.Length-1].arrwordcreate();
   karar[karar.Length-1].consoleprint();
>>>>>>> parent of 3c594b5... Промежуток-промежуточек
      
   this.brain.clonn(karar);
   this.brain.printt();
   
   
	 } //end srtpar method
		
		public heart returnheart()
		{
			
			return this.brain;
		}
	}// end srtparccl class 
}//end name space


