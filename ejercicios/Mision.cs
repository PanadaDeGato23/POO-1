using UnityEngine;

public class Mision
{
    public string Titulo;
    public string Descripcion;
    public int ExpRecompensa;
    public bool Completado;
    
    public Mision(string title, string desc, int xp, bool completed)
    {
        Titulo = title;
        Descripcion = desc;
        ExpRecompensa = xp;
        Completado = completed;
    }

    public void MostrarMision()
    {
        Debug.Log("Título: " + Titulo);
        Debug.Log("Descripción: " + Descripcion);
        Debug.Log("Recompensa: " + ExpRecompensa);
        Debug.Log("Completada: " + Completado);
    }
}