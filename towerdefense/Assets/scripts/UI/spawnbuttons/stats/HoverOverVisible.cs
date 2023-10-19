using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class HoverOverVisible : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject makeVisible;
    public TextMeshProUGUI stats;

    void Start()
    {
        stats = makeVisible.GetComponent<TextMeshProUGUI>();
        stats.alpha = 0; 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        stats.alpha = 255;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        stats.alpha = 0;
    }
}
