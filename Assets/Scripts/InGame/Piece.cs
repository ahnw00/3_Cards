using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    GameManager gameManager;
    public int pieceNum;
    public bool runningOnCoroutine = false;
    public Board board;
    public int boardNum = 0;
    Transform[] boardPos;
    
    void Start()
    {
        gameManager = GameManager.instance;
        boardPos = board.boardPos;
        transform.position = new Vector3(boardPos[boardNum].transform.position.x, this.transform.position.y, -1);
    }

    public IEnumerator MoveCoroutine()
    {
        runningOnCoroutine = true;
        Vector3 NewPos = new Vector3(boardPos[boardNum].transform.position.x, this.transform.position.y, -1);
        float time = 0;
        float speed = 0.3f;
        while(Vector2.Distance(transform.position, NewPos) > 0.01f)
        {
            time += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(transform.position, NewPos, time);
            yield return null;
        }
        transform.position = NewPos;
        runningOnCoroutine = false;
    }

    public void MovePiecePos(int moveNum)
    {
        boardNum += moveNum;
        if(boardNum >= 11)
        {
            boardNum = 11;
            Debug.Log("Game End");
        }
        StartCoroutine(MoveCoroutine());
    }
}
