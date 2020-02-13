using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBoots : Item
{
    void Start(){
        addToInventory = true;
    }
    public override void OnPickUp()
    {
        //we can only wear one pair of boots at a time!
        foreach(Item i in inventorySystem.GetInventory()){
            if(i.GetType() == typeof(SpecialBoots)){
                //we are looping through a copy of the inventory, so removing items from it shouldn't break anything
                inventorySystem.DropItem(i);
                
            }
        }
        base.OnPickUp();//will deactivate the object
        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color;
    }
    public override void OnDrop(){
        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().color = Color.white;
        Destroy(gameObject);//you don't get to keep wearing boots -_-
    }
   
}
