using UnityEngine;
public class Armor: Item
{
    public int defense;
    public int resistance;
    public int weight;

    public Armor(string name, int level, int durab, string abill, int def, int res, int wg) : 
    base(name, level, durab, abill)
    {
        defense = def;
        resistance = res;
        weight = wg;
        
    }

    public override void ShowEquip()
    {
        base.ShowEquip();
        Debug.Log("Defense: "+defense);
        Debug.Log("Resistance: "+resistance);
        Debug.Log("Weight: "+weight);
    }

    public void Equip()
    {
        Debug.Log(equipName + " Equiped");
    }

}