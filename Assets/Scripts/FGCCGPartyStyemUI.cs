using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FGCCGPartyStyemUI : MonoBehaviour
{
    [Header("Card Info")]
    public string CardName;
    [TextArea(4, 10)]
    public string Effect;
    public Sprite Cardpic;
    public int stocks;

    [Header("ui elements")]
    [SerializeField] TextMeshProUGUI nameUI;
    [SerializeField] TextMeshProUGUI effectUI;
    [SerializeField] Image imageUI;
    [SerializeField] List<GameObject> stocksUI;

    private void Update()
    {
        if (Input.GetKeyDown((KeyCode.LeftBracket)))
        {
            StartCoroutine(TakeScreenShot());
        }
    }
    // Update is called once per frame
    void OnValidate()
    {

        //keeping ui up to date
        nameUI.text = CardName;
        effectUI.text = Effect;
        imageUI.sprite = Cardpic;

        for (int lcv = 0; lcv < stocksUI.Count; lcv++)
        {
            stocksUI[lcv].SetActive(false);
        }

        int clamped = Mathf.Clamp(stocks, 0, 5);
        for(int lcv=0;lcv<clamped;lcv++)
        {
            stocksUI[lcv].SetActive(true);
        }
    }

    IEnumerator TakeScreenShot()
    {
        yield return new WaitForEndOfFrame();
        ScreenCapture.CaptureScreenshot(CardName + ".png", 4);
        Debug.Log(CardName + " has been captured");
        //not sure why the thingy is failing idk --> "/F:/ART!!!!/Games/Mad Scientist Card Game/Layout Maker Assets"
    }
}
