using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatistics : MonoBehaviour
{
    //Accesing PlayerObject and its Script
    public GameObject my_Player;
    PlayerScript playerScript;

    //Called at the start
    void Start()
    {
        //Accesing player statistics

        //Accesing PlayerScript
        playerScript = my_Player.GetComponent<PlayerScript>();
        //Agility
        TextMeshProUGUI AgText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Agility").GetComponent<TextMeshProUGUI>();
        AgText.text = $"Agility: {playerScript.Agility}";
        //Strength
        TextMeshProUGUI StrText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Strength").GetComponent<TextMeshProUGUI>();
        StrText.text = $"Strength: {playerScript.Strength}";
        //WillPower
        TextMeshProUGUI WillText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Willpower").GetComponent<TextMeshProUGUI>();
        WillText.text = $"WillPower: {playerScript.WillPower}";
        //Perception
        TextMeshProUGUI PercText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Perception").GetComponent<TextMeshProUGUI>();
        PercText.text = $"Perception: {playerScript.Perception}";
        //Charisma
        TextMeshProUGUI CharText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Charisma").GetComponent<TextMeshProUGUI>();
        CharText.text = $"Charisma: {playerScript.Charisma}";
        //Toughness
        TextMeshProUGUI TouText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Toughness").GetComponent<TextMeshProUGUI>();
        TouText.text = $"Toughness: {playerScript.Toughness}";
        //HP
        TextMeshProUGUI HPText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/HealthPoints").GetComponent<TextMeshProUGUI>();
        HPText.text = $"HP: {playerScript.currentHP}/{playerScript.HP}";
        //Free Point
        TextMeshProUGUI FreeText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/FreePoints").GetComponent<TextMeshProUGUI>();
        FreeText.text = $"Free Points: {playerScript.FreePoints}";
        //Gold
        TextMeshProUGUI GoldText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Gold").GetComponent<TextMeshProUGUI>();
        GoldText.text = $"Gold: {playerScript.Gold}";
        //Level
        TextMeshProUGUI LvlText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Level").GetComponent<TextMeshProUGUI>();
        LvlText.text = $"Level: {playerScript.Lvl}";
        //Experience
        TextMeshProUGUI ExpText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Exp").GetComponent<TextMeshProUGUI>();
        ExpText.text = $"Exp: {playerScript.CurrentExp}/{playerScript.ExpNeeded}";
        
        //HPBarText
        TextMeshProUGUI HpBarText = GameObject.Find("InGameUI/InGameUICanvas/HealthBar/HealthPointsBar").GetComponent<TextMeshProUGUI>();
        HpBarText.text = $"{playerScript.currentHP} /{playerScript.HP}";
        //ExpBarText
        TextMeshProUGUI ExpBarText = GameObject.Find("InGameUI/InGameUICanvas/ExpBar/ExpPointBar").GetComponent<TextMeshProUGUI>();
        ExpBarText.text = $"{playerScript.CurrentExp}/{playerScript.ExpNeeded}";
        //GoldText
        TextMeshProUGUI GoldBarText = GameObject.Find("InGameUI/InGameUICanvas/GoldBar/GoldBarText").GetComponent<TextMeshProUGUI>();
        GoldBarText.text = $"{playerScript.Gold}";
        //LvLBarText
        TextMeshProUGUI LvlBarText = GameObject.Find("InGameUI/InGameUICanvas/LevelBar/LevelBarText").GetComponent<TextMeshProUGUI>();
        LvlBarText.text = $"{playerScript.Lvl}";

    }

    //Called every frame
    void Update()
    {

        //Accesing player statistics

        //Accesing PlayerScript
        playerScript = my_Player.GetComponent<PlayerScript>();
        //Agility
        TextMeshProUGUI AgText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Agility").GetComponent<TextMeshProUGUI>();
        AgText.text = $"Agility: {playerScript.Agility}";
        //Strength
        TextMeshProUGUI StrText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Strength").GetComponent<TextMeshProUGUI>();
        StrText.text = $"Strength: {playerScript.Strength}";
        //WillPower
        TextMeshProUGUI WillText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Willpower").GetComponent<TextMeshProUGUI>();
        WillText.text = $"WillPower: {playerScript.WillPower}";
        //Perception
        TextMeshProUGUI PercText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Perception").GetComponent<TextMeshProUGUI>();
        PercText.text = $"Perception: {playerScript.Perception}";
        //Charisma
        TextMeshProUGUI CharText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Charisma").GetComponent<TextMeshProUGUI>();
        CharText.text = $"Charisma: {playerScript.Charisma}";
        //Toughness
        TextMeshProUGUI TouText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Toughness").GetComponent<TextMeshProUGUI>();
        TouText.text = $"Toughness: {playerScript.Toughness}";
        //HP
        TextMeshProUGUI HPText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/HealthPoints").GetComponent<TextMeshProUGUI>();
        HPText.text = $"HP: {playerScript.currentHP}/{playerScript.HP}";
        //Free Point
        TextMeshProUGUI FreeText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/FreePoints").GetComponent<TextMeshProUGUI>();
        FreeText.text = $"Free Points: {playerScript.FreePoints}";
        //Gold
        TextMeshProUGUI GoldText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Gold").GetComponent<TextMeshProUGUI>();
        GoldText.text = $"Gold: {playerScript.Gold}";
        //Level
        TextMeshProUGUI LvlText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Level").GetComponent<TextMeshProUGUI>();
        LvlText.text = $"Level: {playerScript.Lvl}";
        //Experience
        TextMeshProUGUI ExpText = GameObject.Find("CharacterCreation/CharacterCanvas/CharCreaHolder/PlayerStatParameters/Exp").GetComponent<TextMeshProUGUI>();
        ExpText.text = $"Exp: {playerScript.CurrentExp}/{playerScript.ExpNeeded}";

        //HPBarText
        TextMeshProUGUI HpBarText = GameObject.Find("InGameUI/InGameUICanvas/HealthBar/HealthPointsBar").GetComponent<TextMeshProUGUI>();
        HpBarText.text = $"{playerScript.currentHP}/{playerScript.HP}";
        //ExpBarText
        TextMeshProUGUI ExpBarText = GameObject.Find("InGameUI/InGameUICanvas/ExpBar/ExpPointBar").GetComponent<TextMeshProUGUI>();
        ExpBarText.text = $"{playerScript.CurrentExp}/{playerScript.ExpNeeded}";
        //GoldText
        TextMeshProUGUI GoldBarText = GameObject.Find("InGameUI/InGameUICanvas/GoldBar/GoldBarText").GetComponent<TextMeshProUGUI>();
        GoldBarText.text = $"{playerScript.Gold}";
        //LvLBarText
        TextMeshProUGUI LvlBarText = GameObject.Find("InGameUI/InGameUICanvas/LevelBar/LevelBarText").GetComponent<TextMeshProUGUI>();
        LvlBarText.text = $"{playerScript.Lvl}";

    }
}
