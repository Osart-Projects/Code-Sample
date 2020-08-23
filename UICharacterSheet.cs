using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICharacterSheet : MonoBehaviour
{
    //Parameters for Vectors on-screen and off-screen
    public Vector2 offScreenPos;
    public Vector2 onScreenPos;

    //Determining whether object is active
    public bool CharacterSheet = false;

    //Method activating and disactivating an object
    public void GetCharacterSheet()
    {
        if (CharacterSheet == false)
        {
            CharacterSheet = true;
        }
        else
        {
            CharacterSheet = false;
        }
    }

    //Called every frame
    void Update()
    {
        //Moving the Character Sheet on and off screen

        if (CharacterSheet == true)
        {
            transform.position = onScreenPos;
        }
        else
        {
            transform.position = offScreenPos;
        }

    }
}
