namespace DigiMobile
{
	
	public class Destino{

        public Point Posicion { get; set; }
        public Mapa Mapa { get; set; }
        public byte MultiplicadorPasos { get; set; }
        public Personaje[] Enemigos { get; set; }
        public Personaje Boss { get; set; }
        public bool FinalEventIsShop { get; set; }
        public bool FinalEventIsCalumon { get; set; }
        public Destino Siguiente { get; set; }
    }
}
