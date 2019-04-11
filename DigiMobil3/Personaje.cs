
using System;
using System.Collections.Generic;

namespace DigiMobile{
	
	public class Personaje:IComparable,IComparable<Personaje>
    {
		public enum Imagen{
			Quieto1,
			Quieto2,
			Andando1,
			Andando2,
			Festejando1,
			Festejando2,
			AlertaBatalla1,
			AlertaBatalla2,
			Debilitado1,
			Debilitado2,
		}

		SortedList<Imagen,bool[,]> dicImagesBits;

        public string Nombre { get; private set; }

        public Personaje Evolution { get; private set; }
        public Personaje Preevolution { get; private set; }

        public byte VelocidadBase{get;private set;}
    	public byte AtaqueBase { get; private set; }
        public byte VidaBase { get; private set; }
        public byte SenseBase { get; private set; }
        public byte DefensaBase { get; private set; }
        public bool IsInitialForm => Preevolution == null;
        public bool IsLastForm => Evolution == null;
        public bool[,] this[Imagen img] => dicImagesBits[img];

        public int EtapaEvolutiva{
    		get{
    			int etapa=0;
    			Personaje aux=Preevolution;
    			while(aux!=null){
    				
    					etapa++;
    					aux=Preevolution.Preevolution;
    				
    			}
    			
    			return etapa;
    				
    			
    		}
    	}

        #region CompareTo
        int IComparable<Personaje>.CompareTo(Personaje other)
        {
            return CompareTo(other);
        }

        int IComparable.CompareTo(object obj)
        {
            return CompareTo(obj as Personaje);
        }

        int CompareTo(Personaje personaje)
        {
            const int CONTINUAR = 0;
            const int DIFERENTES = -1;

            int compareTo = personaje != null ? CONTINUAR : DIFERENTES;
            if (compareTo == CONTINUAR)
                compareTo = Nombre.CompareTo(personaje.Nombre);
            return compareTo;
        }
        #endregion
    }
}
