using System;
using System.Collections.Generic;

namespace DigiMobile{
	public class PersonajeBatalla{
		static Random r=new Random();
		
		Personaje personaje;
		int vida;
		List<CartaAtaque> cartasUsadasSatisfactoriamente;
		//falta saber como funciona la carta powerUp
		public int Ataque{
			get{
				const int MULTIPLICADOR=5;
				
				return personaje.AtaqueBase+CountCard(CartaAtaque.Ataque)*MULTIPLICADOR;
			}
		}
		public int Defensa{
			get{
				const int MULTIPLICADOR=4;
				
				return personaje.DefensaBase+CountCard(CartaAtaque.Defensa)*MULTIPLICADOR;
			}
		}
		
		public int Velocidad{
			get{
				const int MULTIPLICADOR=3;
				
				return personaje.VelocidadBase+CountCard(CartaAtaque.Velocidad)*MULTIPLICADOR;
			}
		}
		public int Vida{
			get{
				return vida;
			}
		}
		public double PorcentajeVida{
			
			get{
				return (Vida/personaje.VidaBase)*100.0;
			}
		}
		public int CountCard(CartaAtaque carta){
			int count=0;
				for(int i = 0;i<cartasUsadasSatisfactoriamente.Count;i++)
					if(cartasUsadasSatisfactoriamente[i]==carta)
						count++;
			return count;
		}
		public void Evolution(CartaEvolucion evoCard){
			int acierto=0;
			switch(evoCard){
				case CartaEvolucion.Evo00:acierto=25;break;
				case CartaEvolucion.Evo01: acierto=35;break;
				case CartaEvolucion.Evo10: acierto=55;break;
				case CartaEvolucion.Evo11: acierto=85;break;
			}
			if(acierto<=r.Next(100)){
				//falta decidir cuanto sube
				//aveces sube de menos y rara vez sube de más (uno más si no es la última)
				
			}
		}
		public bool UsaCartaAtaque(CartaAtaque cartaAtaque){
		    const int INDICEEFECTIVIDAD=23;
		    bool efectivo=r.Next(100)>INDICEEFECTIVIDAD;
		    if(efectivo)
		    {
		      cartasUsadasSatisfactoriamente.Add(cartaAtaque);

		    }
		    return efectivo;
		}
		
	}
}
