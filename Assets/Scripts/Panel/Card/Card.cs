using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Card : MonoBehaviour
{
    public CardSlot detectedSlot;
    public int cardNum;

    void Start()
    {
        cardNum = Int32.Parse(this.gameObject.tag);
    }
    public void DragCard(int inputNum)
    {
        this.GetComponent<RectTransform>().position = Input.mousePosition;
        cardNum = inputNum; // 선택한 카드 번호 넘겨줌
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
