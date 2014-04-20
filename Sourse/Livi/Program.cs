/*
 * Парсер srt файлов
 * Created by SharpDevelop.
 * User: Илья
 * Date: 03.04.2014
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
			Console.Write(DateTime.Now.Hour.ToString()+":");
			Console.Write(DateTime.Now.Minute.ToString()+":");
			Console.Write(DateTime.Now.Second.ToString()+",");
			Console.WriteLine(DateTime.Now.Millisecond.ToString());
			
			string sSrtFullPath=@"";
			if (args.Length==0){sSrtFullPath=@"C:\testfiles\srt\in\tiny.srt";} //tiny
			else{sSrtFullPath=@"C:\testfiles\srt\in\"+args[0]+".srt";}
			
			string[] inFile =System.IO.File.ReadAllLines(sSrtFullPath);
						
			srtparcl comq =new srtparcl();
			comq.srtpar(inFile);
			comq.brain.printt();
			
			Console.Write(DateTime.Now.Hour.ToString()+":");
			Console.Write(DateTime.Now.Minute.ToString()+":");
			Console.Write(DateTime.Now.Second.ToString()+",");
			Console.WriteLine(DateTime.Now.Millisecond.ToString());
			
			Console.WriteLine(args[0] +".srt  Обработан...");
			Console.ReadKey(true);
		}
	}
}