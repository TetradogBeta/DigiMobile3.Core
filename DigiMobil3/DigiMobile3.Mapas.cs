using System;
using System.Collections.Generic;
using System.Linq;

namespace DigiMobile{
	public class Mapa:IComparable,IComparable<Mapa>{

        public byte Numero { get; private set; }
        public bool[,] MapaBits { get; private set; }
        public Destino[] Destinos { get; private set; }
        public List<Personaje> Enemigos{
		    
		    get{
		        List<Personaje> enemigos=new List<Personaje>();
		        for(int i=0;i<Destinos.Length;i++){
		           enemigos.AddRange(Destinos[i].Enemigos.Except(enemigos));
		        }
		        return enemigos;
		    }
		}

        #region CompareTo
        int IComparable<Mapa>.CompareTo(Mapa other)
        {
            return CompareTo(other);
        }

        int IComparable.CompareTo(object obj)
        {
            return CompareTo(obj as Mapa);
        }

        int CompareTo(Mapa mapa)
        {
            const int CONTINUAR = 0;
            const int DIFERENTES = -1;

            int compareTo = mapa != null ? CONTINUAR : DIFERENTES;
            if (compareTo == CONTINUAR)
                compareTo = Numero.CompareTo(mapa.Numero);
            return compareTo;
        }
        #endregion
    }
}
