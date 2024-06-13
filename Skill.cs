using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Skill
{
    public string Name
    {
        get; private set;
    }
    private int point;
    public int Point
    {
        get {return point;}
        set {point = value >= 0 ? value : 0;}
    }
    private static int firstLevelXP = 100;
    private static float increaseRate = 1.5f;
    public Skill(string _name, int _point)
    {
        Name = _name;
        Point = _point;
    }
    public int CurrentLevel
    {
        get 
        {
            if (Point < firstLevelXP)
            return 0;
            return Mathf.FloorToInt(Mathf.Log(Point / firstLevelXP) / Mathf.Log(increaseRate));
        }
    }
    public static int GetThresholdOfLevel(int level)
    {
        if (level < 0)
        {
            Debug.Log("Level can't be smaller than 0");
            return -1;
        }
        else if (level == 0)
        {
            return 0;
        }
        else 
        {
            return (int)(firstLevelXP * Mathf.Pow(increaseRate, level));
        }
    }
    
}

public class SkillCollection : Collection<Skill>
{
    public SkillCollection() : base()
    {
        listAttributes.Add("Unarmed", new Skill("Unarmed", 0));
        listAttributes.Add("One Handed Sword", new Skill("One Handed Sword", 0));
        listAttributes.Add("Shield", new Skill("Shield", 0));
        listAttributes.Add("One Handed Spear", new Skill("One Handed Spear", 0));
    }
}