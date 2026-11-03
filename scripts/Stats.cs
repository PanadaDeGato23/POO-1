using UnityEngine;

public class Stats
{
    public int healthPoints;
    public int magicPoints;
    public int strength;
    public int vitality;
    public int resistance;
    public int intelligence;
    public int attack;
    public int defense;
    public int speed;
    public int stamina;

    public Stats(int hp, int mp, int st, int vt, int rs, int it, int atk, int def, int sp, int stm)
    {
        healthPoints = hp;
        magicPoints = mp;
        strength = st;
        vitality = vt; 
        resistance = rs;
        intelligence = it;
        attack = atk;
        defense = def; 
        speed = sp;
        stamina = stm;
    }
}