
using System.Collections.Generic;

namespace DigiMobile{
	
	public class Personaje{
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
		string nombre;
		SortedList<Imagen,bool[,]> dicImagesBits;
	    
	    byte velocidad;
	    byte ataque;
	    byte vida;
	    byte sense;
	    
	    Personaje evolution;
	    Personaje preevolution;
	    
	    public string Nombre=>nombre;
	    
	    public byte VelocidadBase{
    		get{
    			return velocidad;
    		}
    	}
    	public byte AtaqueBase{
    		get{
    			return ataque;
    		}
    	}
    	public byte VidaBase{
    		get{
    			return vida;
    		}
    	}
    	public byte SenseBase{
    		get{
    			return sense;
    		}
    	}
	    public bool IsInitialForm{
    		get{
    			return preevolution==null;
    		}
    	}
	    public bool IsLastForm{
    		get{
    			return evolution==null;
    		}
    	}
    	public int EtapaEvolutiva{
    		get{
    			int etapa=0;
    			Personaje aux=preevolucion;
    			while(aux!=null){
    				
    					etapa++;
    					aux=preevolucion.preevolucion;
    				
    			}
    			
    			return etapa;
    				
    			
    		}
    	}
    	public bool[,] this[Imagen img]{
    	    
    	    get{return dicImagesDic[img];}
    	}
	}
}
