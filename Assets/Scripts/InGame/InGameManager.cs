using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InGameManager : MonoBehaviour
{
    public static InGameManager instance;
    SlotManager slotManager;
    GameManager gameManager;
    public bool player1Turn, player2Turn = false;
    public bool showingResult = false;
    [SerializeField] Piece p1Piece, p2Piece;
    [SerializeField] Text endText;
    [HideInInspector] public int round = 0;
    public GameObject cutton, gameEnd, loading, cuttonCover;
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

        //p1 선공
        if(!gameManager.firstChange)
        {
            p2Piece.boardNum++;
            p2Piece.StartCoroutine(p2Piece.MoveCoroutine());
            player1Panel.SetActive(true);
            player1Turn = true;
        }
        //p2 선공
        else
        {
            p1Piece.boardNum++;
            p1Piece.StartCoroutine(p1Piece.MoveCoroutine());
            player2Panel.SetActive(true);
            player2Turn = true;
        }

        StartCoroutine(TurnManager());
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
                yield return new WaitForSeconds(5f);
                if(!p1Piece.runningOnCoroutine && !p2Piece.runningOnCoroutine)
                {
                    if(!gameManager.firstChange) { player1Turn = true; }
                    else { player2Turn = true; }

                    showingResult = false;
                    break;
                }
            }

            if(p1Piece.boardNum == 11 || p2Piece.boardNum == 11) 
            {
                gameEnd.SetActive(true);
                if(p1Piece.boardNum == 11)
                {
                    endText.text = "플레이어 1 승리";
                }
                else
                {
                    endText.text = "플레이어 2 승리";
                }
                break; 
            } 
            cutton.SetActive(true);

            //p1 선공
            if(!gameManager.firstChange)
            {
                while(player1Turn) { yield return null; }
                cutton.SetActive(true);
                loading.SetActive(false);

                while(player2Turn) { yield return null; }
                cuttonCover.SetActive(true);
                cutton.SetActive(true);
                loading.SetActive(true);
            }
            //p2 선공
            else
            {
                while(player2Turn) { yield return null; }
                cutton.SetActive(true);
                loading.SetActive(false);

                while(player1Turn) { yield return null; }
                cuttonCover.SetActive(true);
                cutton.SetActive(true);
                loading.SetActive(true);
            }
        }

        GetResult();    
    }

    void GetResult()
    {
        if(p1Piece.boardNum == 11)
        {
            gameManager.p1score += 1;
        }
        else
        {
            gameManager.p2score += 1;
        }
    }
}
