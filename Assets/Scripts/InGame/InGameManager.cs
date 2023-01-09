using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameManager : MonoBehaviour
{
    public static InGameManager instance;
    SlotManager slotManager;
    GameManager gameManager;
    public bool player1Turn, player2Turn = false;
    [SerializeField] Piece p1Piece, p2Piece;
    public bool showingResult = false;
    [HideInInspector] public int round = 0;
    public GameObject cutton, gameEnd;
    public GameObject player1Panel, player2Panel;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        slotManager = SlotManager.instance;
        gameManager = GameManager.instance;
        StartCoroutine(TurnManager());
        player1Turn = true;

        if(gameManager.firstChange)
        {
            p1Piece.boardNum++;
            p1Piece.StartCoroutine(p1Piece.MoveCoroutine());
            //
        }
        else
        {
            p2Piece.boardNum++;
            p2Piece.StartCoroutine(p2Piece.MoveCoroutine());
            //
        }
        
    }

    IEnumerator TurnManager()
    {
        while(true)
        {
            yield return null;

            round++;

            while((!player1Turn && !player2Turn && !showingResult)) { yield return null; }

            while(showingResult)
            {
                yield return new WaitForSeconds(4f);
                if(!p1Piece.runningOnCoroutine && !p2Piece.runningOnCoroutine)
                {
                    player1Turn = true;
                    showingResult = false;
                    break;
                }
            }

            if(p1Piece.boardNum == 11 || p2Piece.boardNum == 11) 
            {
                gameEnd.SetActive(true);
                break; 
            } 
            cutton.SetActive(true);

            while(player1Turn) { yield return null; }
            cutton.SetActive(true);

            while(player2Turn) { yield return null; }
            cutton.SetActive(true);
        }

        GetResult();
    }

    void GetResult()
    {
        //
    }
}
