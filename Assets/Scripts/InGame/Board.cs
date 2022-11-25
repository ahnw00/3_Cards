using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public bool isTherePieceOnBoard = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(!isTherePieceOnBoard)
        {
            isTherePieceOnBoard = true;
            col.GetComponent<Piece>().detectedBoard = this;


        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(isTherePieceOnBoard == true)
        {
            isTherePieceOnBoard = false;
            col.GetComponent<Piece>().detectedBoard = null;

    
        }
    }

}
