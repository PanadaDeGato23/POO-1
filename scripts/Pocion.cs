using UnityEngine;

public class Pocion
{
    public string NombrePocion;
    public Element elementoAsociado;
    
    public Pocion(string NombrePocion, Element elementoAsociado)
    {
        this.NombrePocion = NombrePocion;
        this.elementoAsociado = elementoAsociado;
    }

    public void MostrarPocion()
    {
        Debug.Log("Pocion: " + NombrePocion + " Elemento: " + elementoAsociado.tipo + " Descripcion: " + elementoAsociado.description);
    }
}