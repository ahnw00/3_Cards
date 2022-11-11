using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDetector : MonoBehaviour
{
    public bool isThereCardOnSlot = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Card"))
        {
            isThereCardOnSlot = true;
            col.GetComponent<CardDrag>().detectedSlot = this;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Card"))
        {
            isThereCardOnSlot = false;
            col.GetComponent<CardDrag>().detectedSlot = null;
        }
    }
}
