using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class DialTexts : MonoBehaviour
{
    //Variable used for determining random dialogue you get upon interaction with an NPC
    public int RandomDialogue;

    void Start()
    {
        //Accesing game objects

        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();

        //Setting default City Greetings message
        IntroText.text = "Greetings adventurer.";
    }

    //LOCATIONS

    //SEWERS

    //Entering the Sewers
    public void Sewers()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "Again to this black pit...";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "I may not see the sunlight again...";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "Another day in the darkness...";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "Here we go again...";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "I hope I'll survive...";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "Terrible things lrk there...";
        }
    }

    //BROTHEL

    //Entering the Brothel
    public void Brothel()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "I'm back girls!";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "Did you missed me?";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "Let's go!";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "Ooooohh Yeaah!";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "Live is Gooood!";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "Alright! Rund two!";
        }
    }

    //STORE

    //Entering the store
    public void Store()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "Hey! Ya got something new?";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "Where are those heavy bracers?";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "Good old plate helmet.";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "This is a good sword.";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "Warhammer!";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "They have a Baneblade!";
        }
    }

    //QUESTBOARD

    //Coming to the questboard
    public void QuestBoard()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "How the flying fuck am I supposed to do that?!";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "Kill what?!";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "You need five ounces of mercurializaroada eee?";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "Three magical leafes. Easy. Guarded by, repeat please, how many?";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "Can you repeat that Demon part again?";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "Steal a Crown from Dragon's nest? Eeeaaasssy...";
        }
    }

    //CHAPEL

    public void ChapelEntrance()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "You walk the white steps leading to the temple.";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "You enter the temple of the Deity.";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "You came to the house of Gods.";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "You arrived at the temple.";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "You are at the Temple.";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "You feel slightly better as you enter the temple.";
        }
    }

    //Talking to a Priest
    public void Priest()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "What troubles you my child?";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "Are you in need of healing?";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "Yes?";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "What do you seek?";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "How can I help?";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "Beware of the aliens, the mutants, the heretics!";
        }
    }

    //TAVERN

    //Buing room from the Innkeeper
    public void TavernRoom()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "Gold for me, room for you.";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "Just don't make too much noise.";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "Don't bring girls from the brothel to the room will ya?";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "I know such a good room for such a low price.";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "It is yours for now.";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "Lucky you. I just cleaned it.";
        }
    }

    //Entering the tavern
    public void TavernEntrance()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "Scent of beer and farts surround you as you enter the tavern.";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "Ah, feels like home.";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "Innkeeper nods to you as you enter.";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "Some folks glare at you briefly and return to their drinks.";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "Dim light, dirty bodies and terrible bewerage. Home, sweet home.";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "Ah, Taver. Always a good place.";
        }
    }

    //Using a tavern room
    public void Rooms()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "It was a good rest.";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "You feel rested.";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "Sleeping is good.";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "You needed that.";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "Room wasn't that bad.";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "You managed to rest.";
        }
    }

    //"Heard any rumors lately?" from the Innkeeper
    public void TavernRumors()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "I heard that it is dangerous to pick a Succubi in the brothel.";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "Don't try to leave the town, they haven't added the outside world yet.";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "If ya purchase a room, ya get a berr for free!";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "They say vampires killed someone again, but I don't really believe it.";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "I heard that now city has over 19 races! With orcs, trolls, humans, dwarfs, demons, halflings, elves (stfu!), goblins, werewolves, vampires and kitsune being most popular.";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "Nope, nothing new really.";
        }
    }

    //Talking to Warrior in the tavern
    public void Fighter()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "I used to be an adventurer like you.";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "Log'thar'o... I am such a pussy...";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "Have you heard about the High Elves?";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "Trixie on the other side of the street is the best.";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "A city where Demons and Vampires are lawyers. Well, maybe this is hell?";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "You wanna live forever?";
        }
    }

    //Talking to mage in the tavern
    public void Fangalf()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        RandomDialogue = Random.Range(1, 7);
        if (RandomDialogue == 1)
        {
            IntroText.text = "I was in the mines once. Discovered my cleaning recipe there.";
        }
        else if (RandomDialogue == 2)
        {
            IntroText.text = "I have the best horse there is.";
        }
        else if (RandomDialogue == 3)
        {
            IntroText.text = "Your staff is... actually pretty nice one. Where did ya bought it?";
        }
        else if (RandomDialogue == 4)
        {
            IntroText.text = "Have you been in the magic district? They got some serious spells there.";
        }
        else if (RandomDialogue == 5)
        {
            IntroText.text = "Might and Magic!";
        }
        else if (RandomDialogue == 6)
        {
            IntroText.text = "They say there is a bad guy selling jewelery in the magic jewelery store. ";
        }
    }
}
