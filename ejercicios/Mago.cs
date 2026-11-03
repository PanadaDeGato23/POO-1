using UnityEngine;

public class Mago
{
    public string nombre;
    public Habilidad HabilidadPrincipal;

    public Mago(string nombre, Habilidad HabilidadPrincipal)
    {
        this.nombre = nombre;
        this.HabilidadPrincipal = HabilidadPrincipal;
    }

    public void MostrarMago()
    {
        Debug.Log("Mago: " + nombre);
        HabilidadPrincipal.MostrarHabilidad();
    }
}