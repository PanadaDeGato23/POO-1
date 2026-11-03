using UnityEngine;

public class MagoPrueba
{
    public string nombre;
    public HabilidadPrueba HabilidadMago;
    public MagoPrueba(string nombre, HabilidadPrueba HabilidadMago)
    {
        this.nombre = nombre;
        this.HabilidadMago = HabilidadMago;
    }

    public void MostrarMagoPrueba()
    {
        Debug.Log("Nombre del mago: " + nombre);
        HabilidadMago.MostrarHabilidadPrueba();
    }
}