using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMapScript : MonoBehaviour
{
    //Parameters for Vectors on-screen and off-screen
    public Vector2 offScreenPos;
    public Vector2 onScreenPos;

    //Variable determining speed of objects
    public float speed;

    //Determining whether object is active
    public bool Map = false;

    //Method activating and disactivating an object
    public void GetMap()
    {
        if (Map == false)
        {
            Map = true;
        }
        else
        {
            Map = false;
        }
    }


    //Called every frame
    void Update()
    {
        //Moving the map on and off screen

        if (Map == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, onScreenPos, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, offScreenPos, speed * Time.deltaTime);
        }

    }
}