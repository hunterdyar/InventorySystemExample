using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public List<Item> inventory;

    void Start()
    {
        inventory = new List<Item>();
    }
    public bool HaveItemWithName(string itemName)
    {
        foreach (Item item in inventory)
        {
            if(itemName == item.itemName){
                return true;
            }
        }
        return false;
    }
    public void PickupItem(Item item)
    {
        //Item functions sometimes need a reference to this script.
        item.inventorySystem = this;
        item.OnPickUp();
        //now add to our inventory
        if(item.addToInventory){
            if(!inventory.Contains(item)){
                inventory.Add(item);
            }else{
                Debug.Log("item already in inventory");
            }
        }
                
    }
    public void DropItem(Item item)
    {
        if(inventory.Contains(item)){//if we try to remove something we already have.
            inventory.Remove(item);
            item.OnDrop();
        }
    }
    public Item[] GetInventory(){
        //returns a copy of our inventory as an array.
        return inventory.ToArray();
    }
}
