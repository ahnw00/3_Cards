using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour
{
    GameManager gameManager;
    InGameManager inGameManager;
    public static SlotManager instance;
    public CardSlot[] player1CardSlots, player2CardSlots; //cardslot for each player.
    public int[] cardPosX; // card들의 x좌표값 저장
    [SerializeField] Piece p1Piece, p2Piece;
    public int[] player1Card; // selected number list of player1
    public int[] player2Card; // selected number list of player2
    public GameObject[] p1, p2;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        gameManager = GameManager.instance;
        inGameManager = InGameManager.instance;

        for(int i = 0; i < 3; i++)
        {
            player1Card[i] = -1;
            player2Card[i] = -1;
        }
    }

    public void CheckSlotNum(CardSlot[] cardSlots, int[] playerCards)
    {
        for(int i = 0; i < cardSlots.Length; i++)
        {
            playerCards[i] = cardSlots[i].slotNum;
        }
    }

    public void CompareCardNum() // 카드 별 크기 비교 함수
    {
        for(int i = 0; i < 3; i++)
        {
            if((player1Card[i] == 0 && player2Card[i] == 5) || (player1Card[i] > player2Card[i] && !(player1Card[i] == 5 && player2Card[i] == 0 )))
            {
                p1Piece.boardNum++;
                if(p1Piece.boardNum > 11)
                {
                    p1Piece.boardNum = 11;
                }
            }
            
            else if((player1Card[i] == 5 && player2Card[i] == 0) || (player1Card[i] < player2Card[i]))
            {
                p2Piece.boardNum++;
                if(p2Piece.boardNum > 11)
                {
                    p2Piece.boardNum = 11;
                }
            }
        }

        if(!gameManager.firstChange) { StartCoroutine(Delay(p1Piece.MoveCoroutine(), p2Piece.MoveCoroutine())); }
        else { StartCoroutine(Delay(p2Piece.MoveCoroutine(), p1Piece.MoveCoroutine())); }
    }

    IEnumerator Delay(IEnumerator coroutine1, IEnumerator coroutine2)
    {
        yield return StartCoroutine(coroutine1);
        yield return StartCoroutine(coroutine2);
    }

    public void ResetCardDeck(GameObject[] deck) // 덱2 카드 리셋
    {
        if(inGameManager.round % 2 != 0)
        {
            for(int i = 0; i < deck.Length; i++)
            {
                deck[i].SetActive(true);
                deck[i].GetComponent<RectTransform>().anchoredPosition = new Vector2(cardPosX[i], 0);
            }
        }
    }
}