using System.Collections.Generic;

public class EquipmentManager
{
    private readonly Storage storage;
    //Currently all equippable items: armor, one handed weapon, shield. [3]
    public readonly bool isSlotOccupied[];
    //order: armor, one handed weapon, shield

    public EquipmentManager()
    {
        storage = new Storage(3);
        isSlotOccupied = new bool[] {false, false, false};
    }
    public static bool CheckType()
    {
        return false;
    }
}