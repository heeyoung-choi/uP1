using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public PhysicalAttributeCollection PAttributes;
    public string Name
    {
        get; private set;
    }

    public Character(string _name)
    {
        PAttributes = new PhysicalAttributeCollection();
        Name = _name;
    }
    public Character(PhysicalAttributeCollection _PhysicalAttributeCollection, string _name)
    {
        PAttributes = _PhysicalAttributeCollection;
        Name = _name; 
    }
    
}


//ensure number, type and structure of attributes of a character
public class PhysicalAttributeCollection
{
    private readonly Dictionary<string, FloatAttribute> listAttributes;
    public PhysicalAttributeCollection()
    {
    //current attribute Strength, HP, StrengthIncreaseRate, HP RecoveryRate, Endurance, EnduranceIncreaseRate, EnduranceRecoveryRate
        listAttributes = new Dictionary<string, FloatAttribute>();
        listAttributes.Add("Strength", new FloatAttribute("Strength", 10f, false));
        listAttributes.Add("Health", new FloatAttribute("Health", 10f, true));
        listAttributes.Add("StrengthIncreaseRate", new FloatAttribute("StrengthIncreaseRate", 10f, false));
        listAttributes.Add("HealthRecoveryRate", new FloatAttribute("HealthRecoveryRate", 10f, false));
        listAttributes.Add("Endurance", new FloatAttribute("Endurance", 10f, true));
        listAttributes.Add("EnduranceIncreaseRate", new FloatAttribute("EnduranceIncreaseRate", 10f, false));
        listAttributes.Add("Strength", new FloatAttribute("Strength", 10f, false));
    
    }
}
