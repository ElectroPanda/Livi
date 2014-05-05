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
		public string[] saJustallword=new string[1];
		
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
			
			for (int i=0;i<this.heartarr.Length;i++)
			{
				this.heartarr[i].minuslastword();
				ConsoleAsisst.WriteLine("---"+i);
				for (int a=0;a<this.heartarr[i].arrword.Length;a++)
				{
					ConsoleAsisst.WriteLine("***"+this.heartarr[i].arrword[a]+"***");
					//this.heartarr[i].minuslastword();
					if (WordAsisst.HaveCapetalLetter(this.heartarr[i].arrword[a]))
					{
						//Boolean asd=(WordAsisst.HaveDot(this.heartarr[i-1].arrword[this.heartarr[i-1].arrword.Length-1]));
						if (((a==0)||((WordAsisst.HaveDot(this.heartarr[i].arrword[a-1]))==false)))
						{
							
							if (ArrayAsisst.Havethisword(saPublicNames,WordAsisst.klacklac(this.heartarr[i].arrword[a]))==false)
							{
								Array.Resize(ref saPublicNames, saPublicNames.Length+1);
								saPublicNames[saPublicNames.Length-1]=WordAsisst.klacklac(this.heartarr[i].arrword[a]);
								//ConsoleAsisst.Write(WordAsisst.klacklac(this.heartarr[i].arrword[a])+"<<<<<<----");
							}//end if 
							
							if(a==0)
							{
							if (((i>0)))
							{
								if ((this.heartarr[i-1].arrword.Length)>0)
								{
								if((WordAsisst.HaveDot(this.heartarr[i-1].arrword[(this.heartarr[i-1].arrword.Length)-1]))==false)
								{
								Array.Resize(ref saPublicNames, saPublicNames.Length+1);
								saPublicNames[saPublicNames.Length-1]=WordAsisst.klacklac(this.heartarr[i].arrword[a]);
									
								}
								else
						{
							//Тот случай если слово капитализировано по справедливости 
							//- перед словом стоит точка
							string actword=this.heartarr[i].arrword[a];
							actword.ToLower();
							actword=WordAsisst.klacklac(actword);
							if (ArrayAsisst.Havethisword(saJustallword,actword)==false)
							{
								Array.Resize(ref saJustallword, saJustallword.Length+1);
								saJustallword[saJustallword.Length-1]=actword;
							}
							
						} //end else
								}
							}
							}
							
						} //end if Sen Loren
						else
						{
							//Тот случай если слово капитализировано по справедливости 
							//- перед словом стоит точка
							string actword=this.heartarr[i].arrword[a];
							actword.ToLower();
							actword=WordAsisst.klacklac(actword);
							if (ArrayAsisst.Havethisword(saJustallword,actword)==false)
							{
								Array.Resize(ref saJustallword, saJustallword.Length+1);
								saJustallword[saJustallword.Length-1]=actword;
							}
							
						} //end else
					}//end zamok if
					else
					{
						if (ArrayAsisst.Havethisword(saJustallword,WordAsisst.klacklac(this.heartarr[i].arrword[a]))==false)
						{
						Array.Resize(ref saJustallword, saJustallword.Length+1);
						saJustallword[saJustallword.Length-1]=WordAsisst.klacklac(this.heartarr[i].arrword[a]);
						//ConsoleAsisst.WriteLine(WordAsisst.klacklac(this.heartarr[i].arrword[a])+"---");
						}//end if
					}//end else
				} //end Genry For
			} //end Harrison for
			
			
		}// end method
		
		public void JustWordPrint()
		{
			for(int i=1;i<(this.saJustallword.Length);i++)
			{
				ConsoleAsisst.WriteLine(i+")     "+this.saJustallword[i]);
			}
		}//end method
		
	}//end class
}//end name space
