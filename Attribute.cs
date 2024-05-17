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