﻿/*
 * Парсер srt файлов
 * Created by SharpDevelop.
 * User: Илья
 * Date: 20.04.2014
 * Time: 20:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text.RegularExpressions;

namespace Livi

{	
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			ConsoleAsisst.ConsoleTimePrint();
			
			string sSrtFullPath=@"";
			if (args.Length==0){sSrtFullPath=@"C:\testfiles\srt\in\alot\9.srt";} //tiny
			else{sSrtFullPath=@"C:\testfiles\srt\in\"+args[0]+".srt";}
			
			string[] inFile =System.IO.File.ReadAllLines(sSrtFullPath);
						
			srtparcl comq =new srtparcl();
			comq.srtpar(inFile);
			//comq.brain.printt();
			
		     ConsoleAsisst.ConsoleTimePrint();
			
			ConsoleAsisst.Write("   "+sSrtFullPath +"  Обработан...");
			comq.brain.PublicNamesArrCreate();
			//ConsoleAsisst.ReadKey();
		}
	}
}