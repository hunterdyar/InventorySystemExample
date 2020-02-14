using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InClass{
    public class Item : MonoBehaviour
    {
        public string itemName;

        protected int someNumber;

        virtual public void Pickup(Transform quickerPickerUpper)
        {
            Debug.Log("Item Acquired!");
            Destroy(gameObject);
        }
    }
}
