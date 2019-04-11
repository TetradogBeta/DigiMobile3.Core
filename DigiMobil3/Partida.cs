using System.Collections.Generic;

namespace DigiMobile{
	public class Partida{

        const byte TOTALPARTYFRIENDS = 3;//poner todos cuando se sepa lo maximo que he visto ha sido 6 Lopmon,Devimon,UnPerrete...
        const byte TOTALENEMIES = 1;//poner todos cuando se sepa

        public Partida()
        {
            CartasAtaque = new List<CartaAtaque>();
            UltimaDesblqueada = CartaEvolucion.Evo00;
            Party = new Personaje[TOTALPARTYFRIENDS];
            AmigosSecuestrados = new Personaje[TOTALPARTYFRIENDS];
            EnemigosVistos = new Personaje[TOTALENEMIES];

        }

        public byte DEnergy { get; set; }
        public int Steps { get; set; }
        public int BatallasVSGanadas { get; set; }
        public int BatallasVSPerdidas { get; set; }
        public int Distancia { get; set; }
        public Destino PuntoInicio { get; set; }
        public Destino PuntoALlegar { get; set; }
        public Personaje[] Party { get; private set; }
        public Personaje[] EnemigosVistos { get;private set; }
        public Personaje[] AmigosSecuestrados { get;private set; }
        public CartaEvolucion UltimaDesblqueada { get; set; }
        public List<CartaAtaque> CartasAtaque { get;private set; }
    }
}
    
