using UnityEngine;

public class ManagerPrueba : MonoBehaviour
{
    public NPC bardo = new NPC("bardo", "Vendo cosas", true);
    public NPC guerrero = new NPC("guerrero", "No vendo nada", false);
    public FuegoHabilidadPrueba fuego = new FuegoHabilidadPrueba("Fuego", 15, 25);
    public HieloHabilidadPrueba hielo = new HieloHabilidadPrueba("Hielo", 20, 4);
    public MagoPrueba mago = new MagoPrueba("Magordito", new FuegoHabilidadPrueba("Fuego", 15, 25));

    void Start()
    {
        bardo.Hablar();
        guerrero.Hablar();
        fuego.MostrarHabilidadPrueba();
        hielo.MostrarHabilidadPrueba();
        mago.MostrarMagoPrueba();
    }
}