using UnityEngine;

public class HabilidadManager : MonoBehaviour
{
    public NPC goblin = new NPC("Goblin", "Vendo cosas", true);
    public Mision mision = new Mision("Recolectar Recursos", "Recolecta 10 de cuero", 100, false);
    public FuegoHabilidad bolaDeFuego = new FuegoHabilidad("Bola de fuego", 20, 35);
    public HieloHabilidad rayoDeHielo = new HieloHabilidad("Rayo de hielo", 15, 2);

    void Start()
    {
        goblin.Hablar();
        mision.MostrarMision();
        bolaDeFuego.MostrarHabilidad();
        rayoDeHielo.MostrarHabilidad();
        bolaDeFuego.Quemar();
        rayoDeHielo.Congelar();
    }
}