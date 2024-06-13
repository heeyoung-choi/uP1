using System.Collections.Generic;
using UnityEngine;
public class Storage : IIdentifiable
{
    private int limit;
    public int Limit 
    {
        get { return limit; }
        set { limit = value >= 0 ? value : 0; } 

    }

    public string Id
    {
        get;
        private set;
    }
    public Storage(int _Limit = 1)
    {
        Id = GameManager.Instance.CurrentSave.CreateId(this, 2);
        Limit = _Limit;
        ItemList = new List<Item>();
    }
    public readonly List<Item> ItemList;
    private string AddItem(Item item)
    {
        if (ItemList.Count < Limit)
        {
            ItemList.Add(item);
            return "done";
        }
        return "error: limit reached";
    }
    public string ImplementItem(Item item)
    {
        Item implementedItem = item.Clone();
        return AddItem(implementedItem);
    }
    private Item RemoveItem(string itemId)
    {
        for (int i = 0; i < ItemList.Count; i++)
        {
            if (ItemList[i].Id == itemId)
            {
                Item removedItem = ItemList[i];
                ItemList.RemoveAt(i);
                return removedItem;
            }
        }
        return null;
    }
    public string DeleteItem(string itemId)
    {
       int itemRemovedNum = ItemList.RemoveAll(item => item.Id == itemId);
       if (itemRemovedNum == 0)
       {
        return "error: item doesn't exist in storage";
       }
       if (itemRemovedNum != 1)
       {
        return "error: there are more than one item with this id";
       }
       else 
       {
        GameManager.Instance.CurrentSave.IdDict[1].Remove(itemId);
        return "done";
       }
    }
    public string TransferItem(string itemId, Storage storage)
    {
        Item item = this.RemoveItem(itemId);
        if (item == null)
        {
            return "error: item doesn't exist in storage";
        }
        return storage.AddItem(item);

    }
    public string TransferItem(string itemId, string storageId)
    {
        Storage storage = (Storage) GameManager.Instance.CurrentSave.IdDict[2][storageId];
        Item item = this.RemoveItem(itemId);
        if (item == null)
        {
            return "error: item doesn't exist in storage";
        }
        return storage.AddItem(item);
    }
}