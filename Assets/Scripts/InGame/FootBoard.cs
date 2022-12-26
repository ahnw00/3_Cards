using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootBoard : MonoBehaviour
{
    public Board board;

    Transform[] boardPos;
    int plusBoardNum = 0;
    int minusBoardNum = 0; 

    void Start()
    {
        GameObject plusBoard = GameObject.FindWithTag("plusboard");
        GameObject minusBoard = GameObject.FindWithTag("minusboard");
        plusBoardNum = (int)Random.Range(1, 10);
        minusBoardNum = (int)Random.Range(1, 10);
        while(plusBoardNum == minusBoardNum)
        {
            minusBoardNum = (int)Random.Range(1, 10);
        }
        boardPos = board.boardPos;
        plusBoard.transform.position = new Vector3(boardPos[plusBoardNum].transform.position.x, boardPos[plusBoardNum].transform.position.y, -1);
        minusBoard.transform.position = new Vector3(boardPos[minusBoardNum].transform.position.x, boardPos[minusBoardNum].transform.position.y, -1);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(plusBoardNum);
        Debug.Log(col.GetComponent<Piece>().boardNum);
        if(plusBoardNum == col.GetComponent<Piece>().boardNum)
        {
            col.GetComponent<Piece>().boardNum += 1;
            col.GetComponent<Piece>().StartCoroutine(col.GetComponent<Piece>().MoveCoroutine());
        }
        else if(minusBoardNum == col.GetComponent<Piece>().boardNum)
        {

        }
    }

}
