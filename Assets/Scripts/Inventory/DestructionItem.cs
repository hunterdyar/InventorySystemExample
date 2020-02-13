using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionItem : Item
{
    public string tagToDestroyAllOf;
    
    void Start(){
        //override inspector settings.
        addToInventory = false;
    }
    public override void OnPickUp()
    {
        GameObject[] byebye = GameObject.FindGameObjectsWithTag(tagToDestroyAllOf);
        for(int i = 0;i<byebye.Length;i++){
            Destroy(byebye[i]);
        }
        //instantly use this item...
        //in our case it never actually gets added because addToinventory is false.
        //inventorySystem.DropItem(this);  
        gameObject.SetActive(false);
    }
}
