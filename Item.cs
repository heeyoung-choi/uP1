using UnityEngine;
public enum ItemType
{
    MeleeWeapon,
    Armor, 
    Food
}
public class Item : IIdentifiable
{
    public string Name
    {
        get; private set;
    }
    public string Id 
    {
        get; private set;
    }
    public ItemType Type 
    {
        get;
        protected set;
    }
    public bool IsWearable
    {
        get;
        protected set;
    }
     
    protected float basePrice, currentDurability;
    public float MaxDurability
    {
        get; protected set;
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

    public Item(string _Name, float _basePrice, float _currentDurability, float _MaxDurability)
    {
        Id = GameManager.Instance.CurrentSave.CreateId(this, 1);
        Name = _Name;
        basePrice = _basePrice;
        currentDurability = _currentDurability;
        MaxDurability = _MaxDurability;
    }
    public virtual Item Clone()
    {
        return new Item(Name, basePrice, CurrentDurability, MaxDurability);
    }

}

public enum WeaponEnum
{
    OneHandedSword,
    OneHandedSpear,
    Shield
}

public enum WearSlot
{
    OneHand,
    TwoHand,
    Armor



}

public class WearableItem : Item
{
    public WearSlot Slot 
    {
        get; 
        protected set;
    }    
    public WearableItem(string _Name,
    float _basePrice, 
    float _currentDurability, 
    float _MaxDurability) 
    : base( _Name, _basePrice, _currentDurability, _MaxDurability)
    {

    }
}
public class MeleeWeaponItem : WearableItem
{
    public WeaponEnum WeaponType 
    {
        get; private set;
    }
    public float SharpnessCoefficient
    {
        get; private set;
    }
    public float WeightCoefficient
    {
        get; private set;
    }
    public float DefenceCoefficient
    {
        get; private set;
    }

    public MeleeWeaponItem(string _Name,
    float _basePrice, 
    float _currentDurability, 
    float _MaxDurability, 
    WeaponEnum _WeaponType,
    float _SharpnessCoefficient,
    float _WeightCoefficient,
    float _DefenceCoefficient ) 
    : base( _Name, _basePrice, _currentDurability, _MaxDurability)
    {
        Type = ItemType.MeleeWeapon;
        WeaponType = _WeaponType;
        SharpnessCoefficient = _SharpnessCoefficient;
        WeightCoefficient = _WeightCoefficient;
        DefenceCoefficient = _DefenceCoefficient;
    }
    public override Item Clone()
    {
        return new MeleeWeaponItem(Name, 
        basePrice, 
        CurrentDurability, 
        MaxDurability,
        WeaponType,
        SharpnessCoefficient,
        WeightCoefficient,
        DefenceCoefficient
        );
    }
}

public class ArmorItem : WearableItem
{
    public float PenetrationDefenceCoefficient
    {
        get; private set;
    }
    public float BluntDefenceCoefficient
    {
        get; private set;
    }
    public ArmorItem(string _Name, 
    float _basePrice, 
    float _currentDurability, 
    float _MaxDurability,
    float _PenetrationDefenceCoefficient,
    float _BluntDefenceCoefficient)
    : base( _Name, _basePrice, _currentDurability, _MaxDurability)
    {
        PenetrationDefenceCoefficient = _PenetrationDefenceCoefficient;
        BluntDefenceCoefficient = _BluntDefenceCoefficient;
    }
}
