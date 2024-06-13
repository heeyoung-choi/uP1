using System.Collections.Generic;
using UnityEngine;
public class FloatAttribute
{
    //list of effect applied on this attribute
    private bool useCurrentValue = false;
    
    public string Name
    {
        get; private set;
    }
    private float  currentValue;
    public float BaseValue
    {
        get;
        set;
    }
    public float MaxValue 
    {
        get { return BaseValue;}
    }
    public float CurrentValue
    {
        get {return currentValue;}
        set {currentValue = Mathf.Clamp(value, 0, MaxValue);}
    }
    public FloatAttribute(string _name, float _baseValue, bool _useCurrentValue =  false)
    {
        Name = _name;
        BaseValue = _baseValue;
        useCurrentValue = _useCurrentValue;
        if (useCurrentValue) CurrentValue = BaseValue;

    }


}


public class PhysicalAttributeCollection : Collection<FloatAttribute>
{
    
    public PhysicalAttributeCollection() : base()
    {
    //current attribute Strength, HP, StrengthIncreaseRate, HP RecoveryRate, Endurance, EnduranceIncreaseRate, EnduranceRecoveryRate
        
        listAttributes.Add("Strength", new FloatAttribute("Strength", 10f, false));
        listAttributes.Add("Health", new FloatAttribute("Health", 10f, true));
        listAttributes.Add("StrengthIncreaseRate", new FloatAttribute("StrengthIncreaseRate", 10f, false));
        listAttributes.Add("HealthRecoveryRate", new FloatAttribute("HealthRecoveryRate", 10f, false));
        listAttributes.Add("Endurance", new FloatAttribute("Endurance", 10f, true));
        listAttributes.Add("EnduranceIncreaseRate", new FloatAttribute("EnduranceIncreaseRate", 10f, false));
        listAttributes.Add("Strength", new FloatAttribute("Strength", 10f, false));
    
    }
    
}
