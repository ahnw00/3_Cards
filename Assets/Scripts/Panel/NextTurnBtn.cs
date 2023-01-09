using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NextTurnBtn : MonoBehaviour
{
    InGameManager inGameManager;
    public GameObject player1Panel, player2Panel;
    [SerializeField] bool slot0, slot1, slot2;
    [SerializeField] SlotManager slotManager;
    public GameObject[] player1CardDeck, player2CardDeck;

    // Start is called before the first frame update
    void Start()
    {
        inGameManager = InGameManager.instance;
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
                slotManager.CheckSlotNum(slotManager.player1CardSlots, slotManager.player1Card);
                string num1 = slotManager.player1Card[0].ToString();
                string num2 = slotManager.player1Card[1].ToString();
                string num3 = slotManager.player1Card[2].ToString();
                
                for(int i = 0; i < 6; i++) // 카드 덱 리스트에 들어있는 모든 카드 순회
                {
                    if(player1CardDeck[i].tag == num1 || player1CardDeck[i].tag == num2 || player1CardDeck[i].tag == num3) // 슬롯에 올려져있는 카드의 넘버와 일치한다면
                    {
                        player1CardDeck[i].SetActive(false); // 해당카드 꺼줌
                    }
                }
                inGameManager.player1Turn = false;
                inGameManager.player2Turn = true;
                player1Panel.SetActive(false);
            }
            else if(player2Panel.activeSelf)
            {
                slotManager.CheckP2SlotNum();
                string num1 = slotManager.player2Card[0].ToString();
                string num2 = slotManager.player2Card[1].ToString();
                string num3 = slotManager.player2Card[2].ToString();
                
                for(int i = 0; i < 6; i++) // 카드 덱 리스트에 들어있는 모든 카드 순회
                {
                    if(player2CardDeck[i].tag == num1 || player2CardDeck[i].tag == num2 || player2CardDeck[i].tag == num3) // 슬롯에 올려져있는 카드의 넘버와 일치한다면
                    {
                        player2CardDeck[i].SetActive(false); // 해당카드 꺼줌
                    }
                }
                inGameManager.player2Turn = false;
                player2Panel.SetActive(false);
            }
            
        }
    }
}