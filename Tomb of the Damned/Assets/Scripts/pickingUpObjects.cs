using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickingUpObjects : MonoBehaviour
{
    public static string recieveObjectName; // Make it static to access it without an instance
    public static string recieveObjectTag; // Make it static to access it without an instance

    // Update is called once per frame
    void Update()
    {
         Debug.Log("Inside pickingUpObjects, recieveObjectName = " + recieveObjectName);
        if (recieveObjectName == "Sphere")
        {
            Debug.Log("We can pick up this Object");
        }
    }
}