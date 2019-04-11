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
}