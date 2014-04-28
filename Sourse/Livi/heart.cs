/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 12.04.2014
 * Время: 21:14
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace Livi
{
	/// <summary>
	/// Description of karteacl.
	/// </summary>
	public class heart
	{
		public kartochka[] heartarr=new kartochka[2];
		public string[] saPublicNames=new string[1];
		
		public void clonn (kartochka[] a)
		{
			Array.Resize(ref this.heartarr,a.Length);
			this.heartarr = (kartochka[])a.Clone();
			this.heartarr[0]=new kartochka();
	
			
		} //end clonn method
		
		public heart()
		{
			heartarr[1]=new kartochka();
			//Array.Resize(ref this.heartarr,a.Length);
			//kartochka[] heartarr = (kartochka[])a.Clone();
					
		}//end costruct
		
		public void printt()
		{
			//ConsoleAsisst.WriteLine(this.heartarr.Length+"++++++++");
			
			for (int i=1;i<this.heartarr.Length;i++)
			{
				this.heartarr[i].consoleprint();
				
			} //end for
		} //end printt method
		
		public void PublicNamesArrCreate()
		{
			for (int i=1;i<this.heartarr.Length;i++)
			{
				for (int a=1;a<this.heartarr[i].arrword.Length;a++)
				{
					if (WordAsisst.HaveCapetalLetter(this.heartarr[i].arrword[a]))
					{
						if ((WordAsisst.HaveDot(this.heartarr[i].arrword[a-1]))==false)
						{
							//ConsoleAsisst.WriteLine(WordAsisst.klacklac(this.heartarr[i].arrword[a]));
							if (ArrayAsisst.Havethisword(saPublicNames,WordAsisst.klacklac(this.heartarr[i].arrword[a]))==false)
							{
								Array.Resize(ref saPublicNames, saPublicNames.Length+1);
								saPublicNames[saPublicNames.Length-1]=WordAsisst.klacklac(this.heartarr[i].arrword[a]);
								ConsoleAsisst.WriteLine(WordAsisst.klacklac(this.heartarr[i].arrword[a]));
							}//end if 
						} //end if Sen Loren
					}//end zamok if
				} //end Genry For
			} //end Harrison for
		}// end method
		
	}//end class
}//end name space
