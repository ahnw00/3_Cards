using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour
{
    GameManager gameManager;
    public static SlotManager instance;
    public CardSlot[] player1CardSlots, player2CardSlots; //cardslot for each player.
    [HideInInspector] public int[] cardPosX = {-625, -375, -125, 125, 375, 625};
    [SerializeField] GameObject p1CardDeck, p2CardDeck;
    public int[] player1Card; // selected number list of player1
    public int[] player2Card; // selected number list of player2

    public int[] player1Moving = {0, 0, 0}; // 승부 판별 결과
    public int[] player2Moving = {0, 0, 0}; // 승부 판별 결과 안움직인다(0) or 움직인다(1)

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        gameManager = GameManager.instance;

        for(int i = 0; i < 3; i++)
        {
            player1Card[i] = -1;
            player2Card[i] = -1;
        }
    }

    public void CheckP1SlotNum() 
    {// if you click nextTurn Btn of player 1 panel, excute this func
        for(int i = 0; i < player1CardSlots.Length; i++){
            //player1Card[i] = player1CardSlots[i].cardOnSlot.cardNum;
            player1Card[i] = player1CardSlots[i].slotNum;
            //Debug.Log(player1CardSlots[i].cardOnSlot.name);
        }
        
    }
    
    public void CheckP2SlotNum()
    {// if you click nextTurn Btn of player 2 panel, excute this func
        for(int i = 0; i < 3; i++)  player2Card[i] = player2CardSlots[i].cardOnSlot.cardNum;
    }

    public void CompareCardNum() // 카드 별 크기 비교 함수
    {
        for(int i = 0; i < 3; i++)
        {
            if(player1Card[i] > player2Card[i])
            {
                player1Moving[i] = 1;
            }
            else if(player1Card[i] < player2Card[i])
            {
                player2Moving[i] = 1;
            }
        }
    }

    public void ResetCardDeck() // 짝수판 카드 리셋
    {
        if(gameManager.round % 2 == 0)
        {
            for(int i = 0; i < 6; i++)
            {
                p1CardDeck.transform.GetChild(i).GetComponent<RectTransform>().anchoredPosition = new Vector2(cardPosX[i], 0);
                p2CardDeck.transform.GetChild(i).GetComponent<RectTransform>().anchoredPosition = new Vector2(cardPosX[i], 0);
            }
        }
    }
}
