using UnityEngine;

public class NPC
{
    public string Nombre;
    public string Dialogo;
    public bool EsComerciante;
    
    public NPC(string name, string dialog, bool isMerchant)
    {
        Nombre = name;
        Dialogo = dialog;
        EsComerciante = isMerchant;
    }
    public void Hablar()
    {
        Debug.Log(Nombre + ": " + Dialogo + " / " + EsComerciante);
    }
}
