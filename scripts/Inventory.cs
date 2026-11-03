using UnityEngine;

public class Inventory
{
    public string head;
    public string body;
    public string legs;
    public string lefthand;
    public string righthand;
    public string belt;
    public string amulet;
    public string ring;

    public Inventory(string hd, string bd, string lg, string lh, string rh, string bt, string amlt, string rg)
    {
        head = hd;
        body = bd;
        legs = lg;
        lefthand = lh;
        righthand = rh;
        belt = bt;
        amulet = amlt;
        ring = rg;
    }

}