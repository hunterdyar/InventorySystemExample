using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace InClass {
    public class FoodItem : Item
    {
        override public void Pickup(Transform quickerPickerUpper)
        {
            someNumber++;
            Debug.Log("Food item eaten");
            quickerPickerUpper.localScale = quickerPickerUpper.localScale * 1.5f;
            base.Pickup(quickerPickerUpper);
        }

    }

}
