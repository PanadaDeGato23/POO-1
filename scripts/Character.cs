using UnityEngine;

public class Character
{
    public string charName;
    public int level;
    public string job;
    public string type;

    public Character(string name, int lv, string jb, string tp)
    {
        charName = name;
        level = lv;
        job = jb;
        type = tp;
    }

    public virtual void Move()
    {
        
    }

    public virtual void ShowData()
    {
        WriteLine("Name", charName);
        WriteLine("Level", level);
        WriteLine("Job", job);
        WriteLine("Type", type);
        WriteLine("Job - Type", job, type);
        
    }

    public virtual void Interact()
    {
        
    }

    public void WriteLine(string title, string value)
    {
        Debug.Log(title+": "+value+".");
    }

    public void WriteLine(string title, int value)
    {
        Debug.Log(title+": "+value+".");
    }

    public void WriteLine(string title, string value1, string value2)
    {
        Debug.Log(title + ": " + value1 + " - " + value2 + ".");
    }
}