using UnityEngine;

public class Manager : MonoBehaviour
{
    public NPC npc1 = new NPC("npc1", "Mira mis productos", true);
    public NPC npc2 = new NPC("npc2", "¿A que precio los vendes?", false);
    public Mision mision1 = new Mision("Mision1", "Recoger flores", 10, false);
    public FuegoHabilidad bolaDeFuego = new FuegoHabilidad("Bola de fuego", 20, 35);
    public HieloHabilidad rayoDeHielo = new HieloHabilidad("Rayo de hielo", 15, 2);
    public Mago mago = new Mago("Magordito", new FuegoHabilidad("Bola de fuego", 20, 35));
    public Habilidad golpe = new Habilidad("Golpe", 5, Habilidad.TipoHabilidad.Fisica);

    void Start() {
        npc1.Hablar();
        npc2.Hablar();
        mision1.MostrarMision();
        bolaDeFuego.MostrarHabilidad();
        rayoDeHielo.MostrarHabilidad();
        mago.MostrarMago();
        bolaDeFuego.Quemar();
        rayoDeHielo.Congelar();
        golpe.MostrarHabilidad();
    }
}
