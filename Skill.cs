using System.Collections;
using System.Collections.Generic;
public class Skill
{
    public string Name
    {
        get; private set;
    }
    public int Point
    {
        get; private set;
    }
}

public class SkillCollection
{
    public Dictionary<string, Skill> listSkill;
}