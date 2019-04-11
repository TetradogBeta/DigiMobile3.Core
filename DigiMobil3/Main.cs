//+src=DigiMobile3.WindowsSize.cs
//+src=DigiMobile3.Point.cs
//+src=DigiMobile3.PersonajeBatalla.cs
//+src=DigiMobile3.CartaEvolutiva.cs
//+src=DigiMobile3.CartaAtaque.cs
using System;
namespace DigiMobile
{
	public class Program{
		
		public const ConsoleKey EXIT= ConsoleKey.Escape;
		
		public static void Main(){
			ConsoleKey keyPressed;
			InitializeGame();
			Load();
			do{
				keyPressed=Console.ReadKey().Key;	
				if(keyPressed!=EXIT)
				{
					//juega
					
				}
			}while(keyPressed!=EXIT);
			
			Save();
			
		}
		public static void InitializeGame()
		{
			
		}
		public static void Load()
		{
			//cargo  la partida
		}
		public static void Save()
		{
			//guardo la partida
		}
	}
}
