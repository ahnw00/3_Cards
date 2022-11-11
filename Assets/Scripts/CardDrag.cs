using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDrag : MonoBehaviour
{
    public bool isTrigger = true;
    public CardDetector detectedSlot;

    public void DragCard()
    {
        this.GetComponent<RectTransform>().position = Input.mousePosition;
    }

    public void SetCardPos()
    {
        if(detectedSlot && detectedSlot.isThereCardOnSlot)
        {
            Vector2 slotPos = detectedSlot.GetComponent<RectTransform>().position;
            this.GetComponent<RectTransform>().position = slotPos;
        }
    }
}
