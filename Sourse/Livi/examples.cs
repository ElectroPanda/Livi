System.IO.StreamWriter sr=System.IO.File.CreateText(sFullPathTarget);

string[] lines = System.IO.File.ReadAllLines(sFullPathSourse); 


sr.WriteLine(sResult);
sr.Close();
			
			
class Program
	{
		static void Main(string[] args)
{
    			
			
    Console.WriteLine("Работа с регулярными выражениями");
    Console.WriteLine("Введите строку и нажмите Enter");
    string ip = Console.ReadLine();
    string pattern = @"[8]{3,}";
    Regex gex = new Regex(pattern);
    Match sochi = gex.Match(ip);
    while (sochi.Success)
    {
    	Console.WriteLine(args.Length);
    	Console.WriteLine("Success!");
    	Console.WriteLine("Соответствие найдено, позиция {0}, значение {1}", sochi.Index, sochi.Value);
        sochi = sochi.NextMatch();
     }
    Console.ReadLine();
}
		
	}
}			
			