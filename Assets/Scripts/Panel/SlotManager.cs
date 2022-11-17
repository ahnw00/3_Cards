using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour
{
    public static SlotManager slotManager;
    public CardSlot[] player1CardSlots, player2CardSlots; //cardslot for each player.
    [HideInInspector] public int[] cardPosX = {-625, -375, -125, 125, 375, 625};
    public int[] player1Card = {-1, -1, -1}; // selected number list of player1
    public int[] player2Card = {-1, -1, -1}; // selected number list of player2

    void Start()
    {
        slotManager = this;
    }

    public void CheckP1SlotNum() 
    {// if you click nextTurn Btn of player 1 panel, excute this func
        for(int i = 0; i < 3; i++)  player1Card[i] = player1CardSlots[i].slotNum;
    }
    
    public void CheckP2SlotNum()
    {// if you click nextTurn Btn of player 2 panel, excute this func
        for(int i = 0; i < 3; i++)  player2Card[i] = player2CardSlots[i].slotNum;
    }
}
