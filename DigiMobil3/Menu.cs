using System;
using System.Collections.Generic;
using System.Text;

namespace DigiMobile
{
    public class Menu
    {
        public int Id { get; private set; }
        public MenuItem[] Opciones { get; private set; }
    }
    public class MenuItem:IComparable,IComparable<MenuItem>
    {
        public bool[,] ImgBits { get; set; }
        public int Posicion { get; set; }
        public Menu Menu { get; set; }

        #region CompareTo
        int IComparable.CompareTo(object obj)
        {
            return CompareTo(obj as MenuItem);
        }

        int IComparable<MenuItem>.CompareTo(MenuItem other)
        {
            return CompareTo(other);
        }

        private int CompareTo(MenuItem other)
        {
            const int IGUALES = 0;
            const int DIFERENTES = -1;
            int compareTo = other != null && other.Menu.Id == Menu.Id ? IGUALES : DIFERENTES;
            if (compareTo == IGUALES)
                compareTo = Posicion.CompareTo(other.Posicion);
            return compareTo;
        }
        #endregion
    }
}
