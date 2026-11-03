using UnityEngine;
public class Item
{
    public string equipName;
    public int levelRequired;
    public int durability;
    public string abillity;

    public Item(string name, int level, int durab, string abill)
    {
        equipName = name;
        levelRequired = level;
        durability = durab;
        abillity = abill;
    }

    public virtual void ShowEquip()
    {
        Debug.Log("Name: "+equipName);
        Debug.Log("Level Required: "+levelRequired);
        Debug.Log("Durability: "+durability);
        Debug.Log("Abillity: "+abillity);
    }

}