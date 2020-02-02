using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ButtonHoverChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI texto;


    public void OnPointerEnter(PointerEventData eventData)
    {
        texto.color = Color.gray;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        texto.color = Color.black;
    }
}
