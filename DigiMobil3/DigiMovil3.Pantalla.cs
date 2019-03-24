using System;
using System.Collections.Generic;

namespace DigiMobile {
    public delegate T GetPJRepresentationMethod<T>(bool[,] imgBits);

    public class Pantalla<T>
    {
        SortedList<Personaje, SortedList<Personaje.Imagen, T>> dicImgPersonaje;
        SortedList<Mapa, T> dicImgMapas;
        GetPJRepresentationMethod<T> GetImg;

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
    }
}