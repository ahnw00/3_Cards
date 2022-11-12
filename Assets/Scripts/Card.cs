using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public CardSlot detectedSlot;

    public void DragCard()
    {
        this.GetComponent<RectTransform>().position = Input.mousePosition;
    }

    public void SetCardPos()
    {
        if(detectedSlot)
        {
            Vector2 slotPos = detectedSlot.GetComponent<RectTransform>().position;
            this.GetComponent<RectTransform>().position = slotPos;
        }
    }
}
