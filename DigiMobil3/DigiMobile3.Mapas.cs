using System.Linq;

namespace DigiMobile{
	public class Mapa{
	    
		byte numero;
		bool[,] mapaBits;
		Destino[] Destinos;
		
		public List<Enemigo> Enemigos{
		    
		    get{
		        List<Enemigo> enemigos=new List<Enemigo>();
		        for(int i=0;i<Destinos.Lenght;i++){
		           enemigos.AddRange(Destinos[i].Enemigos.Except(enemigos));
		        }
		        return enemigos;
		    }
		}
	}
}
