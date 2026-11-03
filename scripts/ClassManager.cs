using UnityEngine;

public class ClassManager : MonoBehaviour
{
    public Character character = new Character("Pepito", 2, "Merchant", "Human");
    public Enemy enemy = new Enemy("Pepito Malo", 3, "Rogue", "Goblin", new Stats(100,50,1,1,1,1,15,10,1,1));
    public Player player = new Player("Super Pepito", 2, "Warrior", "Dwarf", new Stats(100,50,40,24,24,1,30,30,20,40), 
    new Inventory("Pepito Helmet", "Pepito Armor", "Pepito Boots", "Pepito Axe", "Pepito Shield", "Pepito Belt", "Pepito Amulet", "Pepito Ring"));   
    public Item equip = new Item("Equipamiento", 2, 10, "Te da +10 de estilo");
    public Accesory ring = new Accesory("Accesorio", 2, 6, "Accesorio con poco estilo", 10, -10);
    public Weapon sword = new Weapon("Arma", 5, 20, "Le pega a los monos", 15, new Element(Element.elemento.Aire, "Airesito"));
    public Armor ironArmor = new Armor("Armadura", 5, 25, "Proteccion metálica", 30, 20, 100);
    public Mago mago = new Mago("Magordito", new FuegoHabilidad("Bola de fuego", 20, 35));
    public Pocion pocionDeFuego = new Pocion("Pocion de Fuego", new Element(Element.elemento.Fuego, "Calorcito"));


    void Start()
    {
        character.ShowData();
        enemy.ShowData();
        player.ShowData();
        equip.ShowEquip();
        ring.ShowEquip();
        sword.ShowEquip();
        ironArmor.ShowEquip();
        ring.Use();
        sword.Attack();
        ironArmor.Equip();
        mago.MostrarMago();
        pocionDeFuego.MostrarPocion();
    }
}