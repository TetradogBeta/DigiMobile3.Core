using System.Collections.Generic;

namespace DigiMobile{
	public class Partida{
		byte dEnergy;
		int steps;
		int batallasVSGanadas;
		int batallasVSPerdidas;
		int distancia;
		Distancia puntoInicio;
		Distancia puntoALlegar;
		Personaje[] party;
		Personaje[] enemigosVistos;
		Personaje[] amigosSecuestrados;
		CartaEvolutiva ultimaDesblqueada;
		List<CartaAtaque> cartasAtaque;
	}
}
    
