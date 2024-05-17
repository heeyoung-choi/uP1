using UnityEngine;
public enum ItemType
{
    MeleeWeapon,
    Food
}
public class Item
{
    public string Name
    {
        get; private set;
    }
     
    private float basePrice, currentDurability;
    public float MaxDurability
    {
        get; private set;
    }
    public float CurrentDurability 
    {
        get {return currentDurability;}
        set {currentDurability = Mathf.Clamp(value, 0, MaxDurability);}
    }
    public float FinalPrice 
    {
        get {return basePrice * CurrentDurability / MaxDurability;}
    }

}