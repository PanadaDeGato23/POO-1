using UnityEngine;

public class Habilidad
{
    public enum TipoHabilidad { Fisica, Magica }
    public string nombreHabilidad;
    public int costoMana;
    public TipoHabilidad tipo;
    public Habilidad(string nombreHabilidad, int costoMana, TipoHabilidad tipo)
    {
        this.nombreHabilidad = nombreHabilidad;
        this.costoMana = costoMana;
        this.tipo = tipo;
    }

    public void Mostrar(string titulo, string valor)
    {
        Debug.Log(titulo + ": " + valor);
    }
    public void Mostrar(string titulo, int valor)
    {
        Debug.Log(titulo + ": " + valor);
    }
    public virtual void MostrarHabilidad()
    {
        Mostrar("Nombre", nombreHabilidad);
        Mostrar("Coste Mana", costoMana);
        Mostrar("Tipo", tipo.ToString());
    }
}

public class FuegoHabilidad : Habilidad
{
    public int daño;

    public FuegoHabilidad(string nombreHabilidad, int costoMana, int daño)
        : base(nombreHabilidad, costoMana, Habilidad.TipoHabilidad.Magica)
    {
        this.daño = daño;
    }

    public override void MostrarHabilidad()
    {
        base.MostrarHabilidad();
        Mostrar("Daño", daño);
    }

    public void Quemar()
    {
        Debug.Log(nombreHabilidad + " quema al objetivo con " + daño + " puntos de daño.");
    }
}

public class HieloHabilidad : Habilidad
{
    public int duracionCongelado;
    public HieloHabilidad(string nombreHabilidad, int costoMana, int duracionCongelado)
    : base(nombreHabilidad, costoMana, Habilidad.TipoHabilidad.Magica)
    {
        this.duracionCongelado = duracionCongelado;
    }

    public override void MostrarHabilidad()
    {
        base.MostrarHabilidad();
        Mostrar("Duracion congelado", duracionCongelado);
    }

    public void Congelar()
    {
        Debug.Log(nombreHabilidad + " congela al objetivo " + duracionCongelado + " segundos.");
    }
}