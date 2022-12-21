using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NextTurnBtn : MonoBehaviour
{
    GameManager gameManager;
    public GameObject player1Panel, player2Panel;
    [SerializeField] bool slot0, slot1, slot2;
    [SerializeField] int Player1slot0Num, Player1slot1Num, Player1slot2Num;
    [SerializeField] int Player2slot0Num, Player2slot1Num, Player2slot2Num;
    [SerializeField] SlotManager slotManager;
    public GameObject[] player1CardDeck;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        slotManager = SlotManager.instance;
    }

    public void ClickNextTurnBtn()
    {
        //bool slot0 = slotManager.player1CardSlots[0].isThereCardOnSlot;
        slot0 = GameObject.Find("Slot (0)").GetComponent<CardSlot>().isThereCardOnSlot;
        slot1 = GameObject.Find("Slot (1)").GetComponent<CardSlot>().isThereCardOnSlot;
        slot2 = GameObject.Find("Slot (2)").GetComponent<CardSlot>().isThereCardOnSlot;
        if(slot0 && slot1 && slot2)
        {
            if(player1Panel.activeSelf)
            {
                slotManager.CheckP1SlotNum();
                Player1slot0Num = GameObject.Find("Slot (0)").GetComponent<CardSlot>().slotNum;
                Player1slot1Num = GameObject.Find("Slot (1)").GetComponent<CardSlot>().slotNum;
                Player1slot2Num = GameObject.Find("Slot (2)").GetComponent<CardSlot>().slotNum;
                
                string num1 = slotManager.player1Card[0].ToString();
                string num2 = slotManager.player1Card[1].ToString();
                
                for(int i = 0; i < 6; i++) // 카드 덱 리스트에 들어있는 모든 카드 순회
                {
                    if(player1CardDeck[i].tag == num1 || player1CardDeck[i].tag == num2) // 슬롯에 올려져있는 카드의 넘버와 일치한다면
                    {
                        player1CardDeck[i].SetActive(false); // 해당카드 꺼줌
                    }
                }
                GameObject.Find("Player1Panel").transform.GetChild(Player1slot0Num).gameObject.SetActive(false);
                GameObject.Find("Player1Panel").transform.GetChild(Player1slot1Num).gameObject.SetActive(false);
                GameObject.Find("Player1Panel").transform.GetChild(Player1slot2Num).gameObject.SetActive(false);
                gameManager.player1Turn = false;
                player1Panel.SetActive(false);
            }
            else if(player2Panel.activeSelf)
            {
                slotManager.CheckP2SlotNum();
                gameManager.player2Turn = false;
                gameManager.showingResult = true;
                player2Panel.SetActive(false);
                Player2slot0Num = GameObject.Find("Slot (0)").GetComponent<CardSlot>().slotNum;
                Player2slot1Num = GameObject.Find("Slot (1)").GetComponent<CardSlot>().slotNum;
                Player2slot2Num = GameObject.Find("Slot (2)").GetComponent<CardSlot>().slotNum;
                GameObject.Find("Player1Panel").transform.GetChild(Player2slot0Num).gameObject.SetActive(false);
                GameObject.Find("Player1Panel").transform.GetChild(Player2slot1Num).gameObject.SetActive(false);
                GameObject.Find("Player1Panel").transform.GetChild(Player2slot2Num).gameObject.SetActive(false);
            }
        }

    }

    void SetOffCard(int slotNumber, string slot, string panel)
    {
        slotNumber = GameObject.Find(slot).GetComponent<CardSlot>().slotNum;
        GameObject.Find(panel).transform.GetChild(slotNumber).gameObject.SetActive(false);
    }

    public void TestBtn() // for slotManger func test. do not discard
    {
        if(player1Panel.activeSelf)
        {
            slotManager.CheckP1SlotNum();
        }
        else if(player2Panel.activeSelf)
        {
            slotManager.CheckP2SlotNum();
        }
    }
}
