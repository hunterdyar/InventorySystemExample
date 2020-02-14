using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InClass{
public class PlayerController : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Item>() != null)
        {
            col.GetComponent<Item>().Pickup(transform);

        }
    }
}

}