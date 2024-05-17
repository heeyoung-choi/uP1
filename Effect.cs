using System.Collections;
using System.Collections.Generic;
public enum EffectType
{
    Addition, 
    Multiplication
}
public class Effect
{
    public string Name
    {
        get; private set;
    }
    public List<EffectOnAttribute> EffectsOnAttribute;
    public Effect(string _name)
    {
        Name = _name;
    }

}
public class EffectOnAttribute
{
   public string Name
    {
        get; private set;
    }
    public EffectType BonusType
    {
        get; private set;
    }
    public float Value 
    {
        get; private set;
    }
    public EffectOnAttribute(string _name, EffectType _bonusType, float _value)
    {
        Name = _name;
        BonusType = _bonusType;
        Value = _value;
    }

    
}