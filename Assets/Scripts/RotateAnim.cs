using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateAnim : MonoBehaviour
{
    public Image spriteAnim;
    [SerializeField] List<Sprite> frames;
    [SerializeField] string RootName;
    private string direction="UP";

    public void Start()
    {
        StartCoroutine(RotateRoutine());
    }
    
    IEnumerator RotateRoutine()
    {
        

        for(int times=0;times<4;times++)
        {
            

            for (int lcv = 0; lcv < frames.Count; lcv++)
            {
                yield return new WaitForSeconds(0.1f);
                spriteAnim.sprite = frames[lcv];
                ScreenCapture.CaptureScreenshot(RootName+direction+lcv + ".png", 4);
                //what the 4 mean? it is the super size parameter so it takes a better resolution screenshot
            }
            //rotate ui image -90°
            //this is setting for the next one because we print 4 times
            spriteAnim.transform.Rotate(0, 0, -90);
            if (times == 0) { direction = "RIGHT"; }
            else if (times == 1) { direction = "DOWN"; }
            else if (times == 2) { direction = "LEFT"; }
        }

    }
}
