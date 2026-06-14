using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RightClickButton : MonoBehaviour, IPointerClickHandler//, IPointerDownHandler, IPointerUpHandler
{
    public UnityEvent OnRightClick;

    [SerializeField] private Color rightClickColor = Color.gray;

    [SerializeField] private float rightClickDuration = 0.1f;

    private Button button;

    void Start()
    {

    }

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Right)
        {
            OnRightClick?.Invoke();
        }
    }
}
