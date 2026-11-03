using UnityEngine;

public class Weapon: Item
{
    public int damage;
    public Element element;

    public Weapon(string name, int level, int durab, string abill, int dmg, Element elem) :
    base(name, level, durab, abill)
    {
      damage = dmg;
      element = elem;  
    }

    public override void ShowEquip()
    {
        base.ShowEquip();
        Debug.Log("Damage: "+ damage);
        Debug.Log("Element: "+ element.tipo);
    }

    public void Attack()
    {
        Debug.Log(damage+" points of damage with "+ equipName);
    }
}