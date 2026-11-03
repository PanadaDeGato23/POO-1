using UnityEngine;

public class Element
{
    public enum elemento
    {
        Aire,
        Tierra,
        Fuego,
        Agua,
        Rayo,
        Hielo,
        Oscuridad,
        Luz
    }

    public elemento tipo;
    public string description;

    public Element(elemento tipo, string desc)
    {
        this.tipo = tipo;
        description = desc;
    }

}
