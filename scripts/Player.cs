using UnityEngine;

public class Player: Character
{
    public Stats stats;
    public Inventory inventory;

    public Player(string name, int lv, string jb, string tp, Stats sts, Inventory inv):
    base(name, lv, jb, tp)
    {
        stats = sts;
        inventory = inv;
    }

    public override void ShowData()
    {
        base.ShowData();
        WriteLine("HP", stats.healthPoints);
        WriteLine("MP", stats.magicPoints);
        WriteLine("ATK", stats.attack);
        WriteLine("DEF", stats.defense);
        WriteLine("Head", inventory.head);
        WriteLine("Left Hand", inventory.lefthand);
        WriteLine("Right Hand", inventory.righthand);
    }

}