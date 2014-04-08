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
		public void srtpar(string[] instar)
	{
		
		
		/*string pattern = @"[8]{3,}";
    Regex gex = new Regex(pattern);
    Match sochi = gex.Match(string);
    while (sochi.Success)*/	
		int i;
		int a;
		string patternA=@"([-]{2,})([>]{1,})";
		i=0;
        a=0;		
		  
		Regex gex =new Regex(patternA);
				
		Console.WriteLine("Подсчёт карточек...");
		for (i=0;i<instar.Length;i++)
		{
			//Console.WriteLine(a);
			//Console.WriteLine(instar[i]);
			if (instar[i]!="")
			{
				Match sochi = gex.Match(instar[i]);
				if (sochi.Success)
				{
					a++;
					//Console.WriteLine(instar[i-1] +"__________"+a);
					
				} //end if
				
			}// end if
		} //end for
	
		Console.WriteLine("Готово.");
		
		kartochka[] karar=new kartochka[a+1];
		
			a=0;
			Console.WriteLine("Создание массива карточек...");
		
	 for (i=0;i<instar.Length;i++)
		{
			
			if (instar[i]!="")
			{
				Match sochi = gex.Match(instar[i]);
				if (sochi.Success)
				{
					a++;
					karar[a]=new kartochka();
					karar[a].setmethod(Convert.ToInt32(instar[i-1]),i-1);
			       // karar[a].consoleprint();
				} //end if
				
			}// end if
		} //end for
		
   Console.WriteLine("Готово.");
		
		
		
		
		
	
	} //end srtpar method
	}// end srtparccl class 
}//end name space


