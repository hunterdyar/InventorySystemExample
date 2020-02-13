using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//our parent item class.
// Has features that ALL of our item types should have.
public class Item : MonoBehaviour
{
    public string itemName;
    public bool addToInventory = true;
    
    [HideInInspector]
    public InventorySystem inventorySystem;//might be useful to have a reference to the inventory for the items?
    
    //"Virtual" just gives permission to children classes to override it.
    public virtual void OnPickUp(){
        //Default behavior will be just vanish.
        //if we destroy the gameObject, we may lose the instance of the item! oops.
        gameObject.SetActive(false);
    }
    public virtual void OnDrop(){
        gameObject.SetActive(true);
    }
}  
