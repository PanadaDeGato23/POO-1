using UnityEngine;

public class NPCPrueba
{
    public string nombre;
    public string dialogo;
    public bool esComerciante;

    public NPCPrueba(string nombre, string dialogo, bool esComerciante)
    {
        this.nombre = nombre;
        this.dialogo = dialogo;
        this.esComerciante = esComerciante;
    }

    public void Hablar()
    {
        Debug.Log(nombre + " : " + dialogo + " / " + esComerciante);
    }
}