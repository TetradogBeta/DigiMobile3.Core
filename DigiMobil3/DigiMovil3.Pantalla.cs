using System;

namespace DigiMovil{
    public delegate T GetPJRepresentationMethod<T>(bool[,] imgBits);
public class Pantalla<T>
{
 SortedList<Personaje,SortedList<Personaje.Imagen,T>> dicImgPersonaje;
GetPJRepresentationMethod<T> GetImg;

public T GetImgPJ(Personaje personaje,Personaje.Imagen img)
{
    if(!dicImgPersonaje.ContainsKey(personaje))
    dicImgPersonaje.Add(personaje,new SortedList<Personaje.Imagen,T>);
    if(!dicImgPersonaje[personaje].ContainsKey(img))
    dicImgPersonaje[personaje].Add(img,GetImg(personaje[img]));
    return dicImgPersonaje[personaje][img];
    
}
}