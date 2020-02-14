using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace InClass {
    public class CameraController : MonoBehaviour
    {
        public Transform thingToFollow;
        Vector3 offset;

        void Start()
        {
            if (thingToFollow == null)
            {
                thingToFollow = GameObject.FindGameObjectWithTag("Player").transform;
            }
            offset = transform.position - thingToFollow.position;
        }

        void Update()
        {
            transform.position = thingToFollow.position + offset;
        }
    }

}