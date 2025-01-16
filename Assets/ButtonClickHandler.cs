using UnityEngine;


public class ButtonClickHandler : MonoBehaviour
{
    private IconChanger _myChanger;

    private void Start()
    {
        _myChanger = GetComponentInParent<IconChanger>();
    }
    
    public void OnButtonLeftClick()
    {
        //leftclick
        Debug.Log("left clicked");
        _myChanger.OptionUp();
    }
   public void OnButtonRightClick()
    {
        //right click
        Debug.Log("right clicked");
        _myChanger.OptionDown();
    }
    
}
