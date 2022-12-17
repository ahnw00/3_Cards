using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurnBtn : MonoBehaviour
{
    GameManager gameManager;
    public GameObject player1Panel, player2Panel;
    [SerializeField] bool slot0, slot1, slot2;
    [SerializeField] SlotManager slotManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        slotManager = SlotManager.instance;

    }

    public void ClickNextTurnBtn()
    {
        slot0 = GameObject.Find("Slot (0)").GetComponent<CardSlot>().isThereCardOnSlot;
        slot1 = GameObject.Find("Slot (1)").GetComponent<CardSlot>().isThereCardOnSlot;
        slot2 = GameObject.Find("Slot (2)").GetComponent<CardSlot>().isThereCardOnSlot;
        if(slot0 && slot1 && slot2)
        {
            if(player1Panel.activeSelf)
            {
                slotManager.CheckP1SlotNum();
                gameManager.player1Turn = false;
            }
            else if(player2Panel.activeSelf)
            {
                slotManager.CheckP2SlotNum();
                gameManager.player2Turn = false;
                gameManager.showingResult = true;
            }
        }
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
