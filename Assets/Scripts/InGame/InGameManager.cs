using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameManager : MonoBehaviour
{
    public static InGameManager instance;
    SlotManager slotManager;
    [HideInInspector] public bool player1Turn, player2Turn = false;
    [SerializeField] Piece p1Piece, p2Piece;
    public bool showingResult = false;
    [HideInInspector] public int round = 0;
    public GameObject cutton;
    public GameObject player1Panel, player2Panel;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        slotManager = SlotManager.instance;
        StartCoroutine(TurnManager());
        player1Turn = true;
    }

    IEnumerator TurnManager()
    {
        while(true)
        {
            yield return null;

            round++;

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
                break;
            }
            
            cutton.SetActive(true);

            while(player1Turn)
            {
                yield return null;
            }
            player2Turn = true;
            cutton.SetActive(true);

            while(player2Turn)
            {
                yield return null;
            }
            cutton.SetActive(true);
        }
    }
}
