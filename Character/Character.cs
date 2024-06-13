    using System.Collections;
    using System.Collections.Generic;
using UnityEngine;

public class Character : IIdentifiable
{
    public PhysicalAttributeCollection PAttributes;
    public SkillCollection Skills;
    public string Id {get; private set;}
    public string Name
    {
        get; private set;
    }

    public Character(string _name)
    {
        Id = GameManager.Instance.CurrentSave.CreateId(this, 0);
        PAttributes = new PhysicalAttributeCollection();
        Skills = new SkillCollection();
        Name = _name;
    }
    public Character(PhysicalAttributeCollection _PhysicalAttributeCollection, SkillCollection _SkillCollection, string _name)
    {
        Id = GameManager.Instance.CurrentSave.CreateId(this, 0);
        PAttributes = _PhysicalAttributeCollection;
        Skills = _SkillCollection;
        Name = _name; 
    }
    
}



//ensure number, type and structure of attributes of a character
