using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILooseScript : MonoBehaviour
{
    //Parameters for Vectors on-screen and off-screen
    public Vector2 offScreenPos;
    public Vector2 onScreenPos;

    //Determining whether object is active
    public bool Loose = false;

    //Method activating and disactivating an object
    public void GetLooseScreen()
    {
        if (Loose == false)
        {
            Loose = true;
        }
        else
        {
            Loose = false;
        }
    }

    //Removes Loose Screen
    public void RemoveLooseScreen()
    {
        PlayerScript playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        playerScript.dmgTaken = 0;
        playerScript.currentHP = playerScript.HP;
        Loose = false;
    }

    //Called every frame
    void Update()
    {
        //Accesing playerScript and checking if player currentHP is >= 0

        PlayerScript playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        if (playerScript.currentHP <= 0)
        {
            Loose = true;
        }

        //Moving the Loose Screen on and off screen

        if (Loose == true)
        {
            transform.position = onScreenPos;
        }
        else
        {
            transform.position = offScreenPos;
        }

    }
}
