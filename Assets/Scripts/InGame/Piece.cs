using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    InGameManager inGameManager;
    public bool runningOnCoroutine = false;
    public Board board;
    public int boardNum = 0;
    Transform[] boardPos;
    
    void Start()
    {
        inGameManager = InGameManager.instance;
        boardPos = board.boardPos;
        transform.position = new Vector3(boardPos[boardNum].transform.position.x, this.transform.position.y, -1);
    }

    public IEnumerator MoveCoroutine()
    {
        this.GetComponent<AudioSource>().Play();
        runningOnCoroutine = true;
        Vector3 NewPos = new Vector3(boardPos[boardNum].transform.position.x, this.transform.position.y, -1);
        float time = 0;
        float speed = 0.4f;
        while(Vector2.Distance(transform.position, NewPos) > 0.01f)
        {
            time += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(transform.position, NewPos, time);
            yield return null;
        }
        transform.position = NewPos;
        runningOnCoroutine = false;
    }
}
