using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public GameObject agBut;
    ButtonActivator buttonActivator;

    //Character atributes
    public int Agility;
    public int Strength;
    public int WillPower;
    public int Perception;
    public int Charisma;
    public int Toughness;

    //Other character parameters
    public int FreePoints;
    public int HP;
    public int dmg;
    public int currentHP;
    public int dmgTaken;
    public int Gold;
    public int Lvl;
    public int CurrentExp;
    public int ExpNeeded;

    //Variables used for random actions
    public int Sew;
    public int Luck;
    public int Roll;

    //Method setting initial game parameters
    public void NewGame()
    {
        //Reseting game parameters
        Agility = 1;
        Strength = 1;
        WillPower = 1;
        Perception = 1;
        Charisma = 1;
        Toughness = 1;
        Gold = 4;
        CurrentExp = 0;
        Lvl = 1;
        dmgTaken = 0;

        //Setting new "You Loose" text
        TextMeshProUGUI IntroText = GameObject.Find("Loose/LooseCanvas/LooseHolder/YouDiedText").GetComponent<TextMeshProUGUI>();
        Luck = Random.Range(1, 7);
        if (Luck == 1)
        {
            IntroText.text = "Executed...";
        }
        else if (Luck == 2)
        {
            IntroText.text = "Slain so violently...";
        }
        else if (Luck == 3)
        {
            IntroText.text = "Another one fell...";
        }
        else if (Luck == 4)
        {
            IntroText.text = "You have fallen...";
        }
        else if (Luck == 5)
        {
            IntroText.text = "Maybe next one will succeed...";
        }
        else if (Luck == 6)
        {
            IntroText.text = "You will be forgotten...";
        }

    }

    //Methods for increasing atributes for free points upon button click

    public void IncrAg()
    {
        Agility += 1;
        FreePoints -= 1;
    }
    public void IncrStr()
    {
        Strength += 1;
        FreePoints -= 1;
    }
    public void IncrWill()
    {
        WillPower += 1;
        FreePoints -= 1;
    }
    public void IncrPer()
    {
        Perception += 1;
        FreePoints -= 1;
    }
    public void IncrChar()
    {
        Charisma += 1;
        FreePoints -= 1;
    }
    public void IncrTou()
    {
        Toughness += 1;
        FreePoints -= 1;
    }

    //Atributes altered upon choosing a race

    public void Human()
    {
        Agility += 2;
        Strength += 2;
        WillPower += 2;
        Perception += 2;
        Charisma += 2;
        Toughness += 2;
    }
    public void Dwarf()
    {
        Strength += 4;
        WillPower += 2;
        Perception += 1;
        Charisma += 1;
        Toughness += 4;
    }
    public void Elf()
    {
        Agility += 4;
        Strength += 1;
        WillPower += 1;
        Perception += 3;
        Charisma += 3;
    }

    //Atributes altered upon choosing parent's jobs

    public void Mages()
    {
        WillPower += 2;
        Perception += 2;
    }
    public void Outlaws()
    {
        WillPower += 2;
        Perception += 2;
    }
    public void Warriors()
    {
        Agility += 2;
        Strength += 1;
        Toughness += 1;
    }

    //Atributes altered upon choosing early life's job

    public void CityGuard()
    {
        Agility += 1;
        Strength += 1;
        WillPower += 1;
        Toughness += 1;
        Gold += Random.Range(1, 7);
    }
    public void Apprientice()
    {
        WillPower += 2;
        Perception += 2;
        Gold += Random.Range(1, 20);
    }
    public void Thief()
    {
        Agility += 2;
        Perception += 2;
        Gold += Random.Range(2, 17);
    }

    //Dialogues directly changing player statistics

    //Healing in the Chapel
    public void HealingChapel()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        Sew = Random.Range(1, 7);
        if (Gold >= 5)
        {
            Gold -= 5;
            dmgTaken -= (Random.Range(1, WillPower));
            if (dmgTaken <= 0)
            {
                dmgTaken = 0;
            }
            if (Sew == 1)
            {
                IntroText.text = "Be blessed my child.";
            }
            else if (Sew == 2)
            {
                IntroText.text = "God be with you.";
            }
            else if (Sew == 3)
            {
                IntroText.text = "May the Deity guard your eternal soul.";
            }
            else if (Sew == 4)
            {
                IntroText.text = "Faith is eternal.";
            }
            else if (Sew == 5)
            {
                IntroText.text = "God bless this wonderfull world.";
            }
            else if (Sew == 6)
            {
                IntroText.text = "Go with blessing my child.";
            }
        }
        else
        {
            if (Sew == 1)
            {
                IntroText.text = "Please, first support our temple.";
            }
            else if (Sew == 2)
            {
                IntroText.text = "Gods don't need money but their servants do.";
            }
            else if (Sew == 3)
            {
                IntroText.text = "We will need a small donation for our humble temple.";
            }
            else if (Sew == 4)
            {
                IntroText.text = "Please consider supporting our temple with little gift.";
            }
            else if (Sew == 5)
            {
                IntroText.text = "We will need some financial support to be able to carry help.";
            }
            else if (Sew == 6)
            {
                IntroText.text = "Please, do show your good intentions through supporting our temple.";
            }
        }
    }

    //Searching the Canal
    public void SearchCanal()
    {
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();
        Sew = Random.Range(1, 7);
        if (Sew == 1)
        {
            Roll = Random.Range(1, 20);
            if (Roll <= Agility)
            {
                IntroText.text = $"Something dark emerged from the canal and tried to take you with it but you dodged in last second.";
            }
            else
            {
                Luck = Random.Range(20, 35);
                dmgTaken += Luck;
                IntroText.text = $"Something dark emerged from the canal and tried to take you with it. You almost fell in the eternal drakness. You lost {Luck} health.";
            }
        }
        else if (Sew == 2)
        {
            Roll = Random.Range(1, 20);
            if (Roll <= Agility)
            {
                IntroText.text = $"You jumped out of the canal a moment before water swirmed in the place where you stood.";
            }
            else
            {
                Luck = Random.Range(12, 25);
                dmgTaken += Luck;
                IntroText.text = $"You were bitten by some devilry. Wound looks nasty. You feel like you lost {Luck} HP.";
            }

        }
        else if (Sew == 3)
        {
            IntroText.text = "Nothing interesting in the wet, dangerous darkness this time.";
        }
        else if (Sew == 4)
        {
            IntroText.text = "You dig in the litter but didn't find anything usefull.";
        }
        else if (Sew == 5)
        {
            Luck = Random.Range(12, 33);
            Gold += Luck;
            IntroText.text = $"You found {Luck} gold coins. Was it really worth it?.";
        }
        else if (Sew == 6)
        {
            Luck = Random.Range(40, 50);
            Gold += Luck;
            IntroText.text = $"Luck is at your side, you have found a coin purse with {Luck} gold.";

        }
    }

    //Done at the start
    void Start()
    {
        UILooseScript looseScript = GameObject.Find("Loose/LooseCanvas/LooseHolder").GetComponent<UILooseScript>();

        //Referencing main dialogue text box
        TextMeshProUGUI IntroText = GameObject.Find("InGameUI/InGameUICanvas/TextLog/LogText").GetComponent<TextMeshProUGUI>();

        //Activating Free Atribute Points buttons
        buttonActivator = agBut.GetComponent<ButtonActivator>();

        //Setting initial maximal HP, and current HP
        HP = Toughness * 5;
        currentHP = HP;

    }

    //Update is called once per frame
    void Update()
    {
        //Experience required for reaching next level
        ExpNeeded = (Lvl * 30);

        //Updating maximum HP from the Toughness value
        HP = Toughness * 5;

        //Updating current HP
        currentHP = HP - dmgTaken;

        //Leveling up - decreasing Exp gained, Increasing Level, providing atribute points
        if (CurrentExp >= ExpNeeded)
        {
            CurrentExp -= ExpNeeded;
            Lvl++;
            FreePoints += 3;
            buttonActivator.ButtonControl();
        }
    }



}
