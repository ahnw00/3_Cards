using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot : MonoBehaviour
{
    public Card cardOnSlot;
    [HideInInspector] public int slotNum;
    public bool isThereCardOnSlot = false;
    
    void OnTriggerEnter2D(Collider2D col) // 카드와 슬롯이 만날 때
    {
        if(!isThereCardOnSlot)
        {
            isThereCardOnSlot = true;
            col.GetComponent<Card>().detectedSlot = this;
            cardOnSlot = col.GetComponent<Card>();
            slotNum = cardOnSlot.cardNum; // 현재 슬롯에 올라가있는 카드의 번호 저장
        }
    }

    void OnTriggerExit2D(Collider2D col) // 카드가 슬롯에서 벗어날 때
    {
        if(col.GetComponent<Card>() == cardOnSlot)
        {
            isThereCardOnSlot = false;
            col.GetComponent<Card>().detectedSlot = null;
            //slotNum = -1;
            cardOnSlot = null;
        }
    }
}
