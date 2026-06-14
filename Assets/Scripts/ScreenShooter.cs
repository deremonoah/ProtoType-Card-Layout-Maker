using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class ScreenShooter : MonoBehaviour
{
    //https://www.youtube.com/watch?v=DyiJpBpOVKA

    [Header("Card Info")]
    public String CardName;
    [TextArea(4, 10)]
    public String Effect;
    public Sprite Cardpic;
    [Header("Card stats")]
    public String Cost;
    public bool textIsForStatsWhite;
    public String Movement;
    public String Int;
    public String HP;
    [Header("dice numbers")]
    public List<String> diceSides;
    [Header("dice #2 numbers & character health")]
    public List<String> diceTWOSides;
    public String CharacterHP;

    [Header("Card info text elements")]
    [SerializeField] TMP_Text cardNameText;
    [SerializeField] TMP_Text cardEffectText;
    [Header("Card stats text elements")]
    [SerializeField] TMP_Text CostText;
    [SerializeField] TMP_Text movementText;
    [SerializeField] TMP_Text intText;
    [SerializeField] TMP_Text HPText;
    [SerializeField] List<TMP_Text> diceTexts;
    [SerializeField] Image CardpictureElement;
    [Header("dice #2 numbers & character health")]
    [SerializeField] List<TMP_Text> diceTWOTexts;
    public TMP_Text CharacterHPText;


    void Update()
    {
        if(Input.GetKeyDown((KeyCode.LeftBracket)))
        {
            StartCoroutine(TakeScreenShot());
        }
        //keeping ui up to date

        cardNameText.text = CardName;
        cardEffectText.text = Effect;
        CardpictureElement.sprite = Cardpic;

        CostText.text = Cost;
        movementText.text = Movement;
        intText.text = Int;
        HPText.text = HP;
        CharacterHPText.text = CharacterHP;

        for(int lcv=0;lcv<diceTexts.Count;lcv++)
        {
            diceTexts[lcv].text = diceSides[lcv];
            diceTWOTexts[lcv].text = diceTWOSides[lcv];
        }

        if(textIsForStatsWhite)
        {
            movementText.color = Color.white;
            intText.color = Color.white;
            HPText.color = Color.white;
        }
        else
        {
            movementText.color = Color.black;
            intText.color = Color.black;
            HPText.color = Color.black;
        }
    }

    IEnumerator TakeScreenShot()
    {
        yield return new WaitForEndOfFrame();
        ScreenCapture.CaptureScreenshot( CardName + ".png", 4);
        Debug.Log(CardName + " has been captured");
        //not sure why the thingy is failing idk --> "/F:/ART!!!!/Games/Mad Scientist Card Game/Layout Maker Assets"
    }
}
