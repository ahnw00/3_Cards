using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public int pieceNum;
    public Board board;
    int boardnum = 0;
    Transform[] boardPos;

    void Start()
    {
        boardPos = board.boardPos;
        //transform.position = boardPos[boardnum].transform.position;
        transform.position = new Vector3(boardPos[boardnum].transform.position.x, boardPos[boardnum].transform.position.y, -1);
    }

    public void MovePiecePos(int moveNum)
    {
        boardnum += moveNum;
        IsItEndPoint();
        //transform.position = boardPos[boardnum].transform.position;
        transform.position = new Vector3(boardPos[boardnum].transform.position.x, boardPos[boardnum].transform.position.y, -1);
    }

    public void IsItEndPoint()
    {
        if(boardnum >= 9)
        {
            transform.position = boardPos[9].transform.position;
            Debug.Log("Game End");

        }
        //Mathf.Lerp()
    }
}
