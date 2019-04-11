using Gabriel.Cat.S.Extension;
using System;
using System.Collections.Generic;

namespace DigiMobile {
    public delegate T GetRepresentationMethod<T>(bool[,] imgBits);
    //la idea es guardar las imagenes para no tener que generarlas todo el tiempo
    public class Pantalla<T>
    {
        SortedList<Personaje, SortedList<Personaje.Imagen, T>> dicImgPersonaje;
        SortedList<Mapa, T> dicImgMapas;
        SortedList<MenuItem, T> dicImgMenuItem;
        GetRepresentationMethod<T> GetImg;

        public Pantalla(GetRepresentationMethod<T> getImgMethod)
        {
            if (getImgMethod == null)
                throw new ArgumentNullException("getImgMethod", "It's required to make images");
            GetImg = getImgMethod;
            dicImgPersonaje = new SortedList<Personaje, SortedList<Personaje.Imagen, T>>();
            dicImgMapas = new SortedList<Mapa, T>();
            dicImgMenuItem = new SortedList<MenuItem, T>();

        }

        public T this[Personaje pj,Personaje.Imagen img]=>GetImgPJ(pj,img);
        public T this[Mapa mapa]=>GetImgMapa(mapa);
        public T this[MenuItem menuItem]=>GetImgMenuItem(menuItem);
        
        public T GetImgPJ(Personaje personaje, Personaje.Imagen img)
        {
            if (!dicImgPersonaje.ContainsKey(personaje))
                dicImgPersonaje.Add(personaje, new SortedList<Personaje.Imagen, T>());
            if (!dicImgPersonaje[personaje].ContainsKey(img))
                dicImgPersonaje[personaje].Add(img, GetImg(personaje[img]));
            return dicImgPersonaje[personaje][img];

        }
        public T GetImgMapa(Mapa mapa)
        {
            if (!dicImgMapas.ContainsKey(mapa))
                dicImgMapas.Add(mapa, GetImg(mapa.MapaBits));
            return dicImgMapas[mapa];
        }
        public T GetImgMenuItem(MenuItem menuItem)
        {
            if (!dicImgMenuItem.ContainsKey(menuItem))
                dicImgMenuItem.Add(menuItem, GetImg(menuItem.ImgBits));
            return dicImgMenuItem[menuItem];
        }

        
    }
    public static class Pantalla
    {
        public static bool[,] GetImgBits(this byte[] bytesImg)
        {
            if (bytesImg == null || bytesImg.Length != (int)WindowsSize.Width * (int)WindowsSize.Height / 2)
                throw new ArgumentException("La array tiene que tener unas medidas concretas (int)WindowsSize.Width*(int)WindowsSize.Height/2 ");

            bool[,] imgBits = new bool[(int)WindowsSize.Width, (int)WindowsSize.Height];
            bool[] byteBits;
            unsafe
            {
                byte* ptrBytesImg;
                fixed (byte* ptBytesImg = bytesImg)
                {
                    ptrBytesImg = ptBytesImg;
                    for (int y = 0, xF = (int)WindowsSize.Width / 2, yF = (int)WindowsSize.Height; y < yF; y++)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            byteBits = (*ptrBytesImg).ToBits();
                            ptrBytesImg++;
                            for (int x = 0; x < xF; x++)
                            {
                                imgBits[x + xF * i, y] = byteBits[x];
                            }
                        }
                    }
                }
            }
            return imgBits;
        }
    }

}