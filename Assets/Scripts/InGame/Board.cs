using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Transform[] boardPos;
    public bool isTherePieceOnBoard = false;
    public int plusBoardNum = 0;
    public int minusBoardNum = 0; 
    public GameObject plusBoard;
    public GameObject minusBoard;

    void Start()
    {
        plusBoardNum = (int)Random.Range(2, 10);
        minusBoardNum = (int)Random.Range(2, 10);
        while(plusBoardNum == minusBoardNum)
        {
            minusBoardNum = (int)Random.Range(2, 10);
        }
        plusBoard.transform.position = new Vector3(boardPos[plusBoardNum].transform.position.x, boardPos[plusBoardNum].transform.position.y, -1);
        minusBoard.transform.position = new Vector3(boardPos[minusBoardNum].transform.position.x, boardPos[minusBoardNum].transform.position.y, -1);
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if(!isTherePieceOnBoard)
        {
            isTherePieceOnBoard = true;
            //col.GetComponent<Piece>().detectedBoard = this;


        }
    }



}
