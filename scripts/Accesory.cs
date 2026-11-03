using UnityEngine;
public class Accesory: Item
{
    public int intelligence;
    public int magicPower; 

    public Accesory(string name, int level, int durab, string abill, int intell, int mp) : 
    base(name, level, durab, abill)
    {
        intelligence = intell;
        magicPower = mp;
    }

    public override void ShowEquip()
    {
        base.ShowEquip();
        Debug.Log("Intelligence: "+intelligence);
        Debug.Log("Magic Power: "+magicPower);
    }

    public void Use()
    {
        Debug.Log(equipName+" Used");
    }
}