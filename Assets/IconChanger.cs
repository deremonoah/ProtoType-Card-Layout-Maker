using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconChanger : MonoBehaviour
{
    private Image iconToChange;
    public List<Sprite> options;
    private int currentOption;

    private void Start()
    {
        iconToChange = GetComponent<Image>();
    }

    private void updateIcon()
    {
        iconToChange.sprite = options[currentOption];
    }

    public void OptionUp()
    {
        currentOption++;
        if(currentOption>options.Count-1)
        {
            currentOption = 0;
        }
        updateIcon();
    }

    public void OptionDown()
    {
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count-1;
        }
        updateIcon();
    }
}
