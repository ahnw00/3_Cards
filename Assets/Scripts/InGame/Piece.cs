using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public int pieceNum;
    public Board detectedBoard;
    public Transform[] boardPos;
    int boardnum = 0;

    public void MovePiecePos(int moveNum)
    {
        boardnum += moveNum;
        IsItEndPoint();
        transform.position = boardPos[boardnum].transform.position;
    }

    void Start()
    {
        transform.position = boardPos[boardnum].transform.position;
    }

    public void IsItEndPoint()
    {
        if(boardnum >= 9)
        {
            transform.position = boardPos[9].transform.position;
            Debug.Log("Game End");

        }

    }




}
