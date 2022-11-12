using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot : MonoBehaviour
{
    [SerializeField] Card cardOnSlot;
    public bool isThereCardOnSlot = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(!isThereCardOnSlot)
        {
            isThereCardOnSlot = true;
            col.GetComponent<Card>().detectedSlot = this;
            cardOnSlot = col.GetComponent<Card>();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.GetComponent<Card>() == cardOnSlot)
        {
            isThereCardOnSlot = false;
            col.GetComponent<Card>().detectedSlot = null;
            cardOnSlot = null;
        }
    }
}
