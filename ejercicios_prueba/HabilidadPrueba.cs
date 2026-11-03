using UnityEngine;

public class HabilidadPrueba
{
    public string nombreHabilidad;
    public int costoMana;

    public HabilidadPrueba(string nombreHabilidad, int costoMana)
    {
        this.nombreHabilidad = nombreHabilidad;
        this.costoMana = costoMana;
    }

    public virtual void MostrarHabilidadPrueba()
    {
        Debug.Log(nombreHabilidad + " Costo Mana: " + costoMana);
    }
}

public class FuegoHabilidadPrueba : HabilidadPrueba
{
    public int daño;
    public FuegoHabilidadPrueba(string nombreHabilidad, int costoMana, int daño)
    : base(nombreHabilidad, costoMana)
    {
        this.daño = daño;
    }

    public override void MostrarHabilidadPrueba()
    {
        base.MostrarHabilidadPrueba();
        Debug.Log("Daño: " + daño);
    }
}

public class HieloHabilidadPrueba : HabilidadPrueba
{
    public int duracionCongelado;
    public HieloHabilidadPrueba(string nombreHabilidad, int costoMana, int duracionCongelado)
    : base(nombreHabilidad, costoMana)
    {
        this.duracionCongelado = duracionCongelado;
    }

    public override void MostrarHabilidadPrueba()
    {
        base.MostrarHabilidadPrueba();
        Debug.Log("Duracion: " + duracionCongelado);
    }
}