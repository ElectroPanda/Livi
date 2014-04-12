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
				
		Console.Write("Подсчёт карточек...");
		for (i=0;i<instar.Length;i++)
		{
			//Console.WriteLine(a);
			//Console.WriteLine(instar[i]);
			if (string.IsNullOrEmpty(instar[i])==false)//if (instar[i]!="")
			{
				Match sochi = gex.Match(instar[i]);
				if (sochi.Success)
				{
					a++;
					//Console.WriteLine(instar[i-1] +"__________"+a);
					
				} //end if
				
			}// end if
		} //end for
	
		Console.Write("Готово.");
		
		kartochka[] karar=new kartochka[a+1];
		
			a=0;
			Console.Write("    Создание массива карточек...");
		
	 for (i=0;i<instar.Length;i++)
		{
			
	 	if (string.IsNullOrEmpty(instar[i])==false)//if (instar[i]!="")
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
   //Console.ReadKey();
		
		
   for (a=1;a<karar.Length-1;a++)
   {
   	for (i=(karar[a].iStartLineN+2);i!=(karar[a+1].iStartLineN-1);i++)
   	{
   		karar[a].settext(instar[i]);
   		//Console.WriteLine(instar[i]);
   	} //end for
   	karar[a].minuslastline();
   	karar[a].arrwordcreate();
   	karar[a].consoleprint();
   }//end for
	
   for (i=(karar[karar.Length-1].iStartLineN+2);i!=(instar.Length);i++)
   {
   	karar[karar.Length-1].settext(instar[i]);
   	
   }// end for
   
   karar[karar.Length-1].minuslastline();
   karar[karar.Length-1].arrwordcreate();
   karar[karar.Length-1].consoleprint();
   heart brain=new heart(karar);
   brain.printt();
	 } //end srtpar method
	}// end srtparccl class 
}//end name space


