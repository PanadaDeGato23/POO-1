using UnityEngine;

public class Enemy: Character
{
    public Stats stats;
    public Enemy(string name, int lv, string jb, string tp, Stats sts)
    : base(name, lv, jb, tp)
    {
        stats = sts;
    }

    public override void ShowData()
    {
        base.ShowData();
        WriteLine("HP", stats.healthPoints);
        WriteLine("MP", stats.magicPoints);
        WriteLine("ATK", stats.attack);
        WriteLine("DEF", stats.defense);

    }
}