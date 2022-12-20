using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurnBtn : MonoBehaviour
{
    GameManager gameManager;
    public GameObject player1Panel, player2Panel;
    [SerializeField] bool slot0, slot1, slot2;
    [SerializeField] int Player1slot0Num, Player1slot1Num, Player1slot2Num;
    [SerializeField] int Player2slot0Num, Player2slot1Num, Player2slot2Num;
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
                Player1slot0Num = GameObject.Find("Slot (0)").GetComponent<CardSlot>().slotNum;
                Player1slot1Num = GameObject.Find("Slot (1)").GetComponent<CardSlot>().slotNum;
                Player1slot2Num = GameObject.Find("Slot (2)").GetComponent<CardSlot>().slotNum;
                GameObject.Find("Player1Panel").transform.GetChild(Player1slot0Num).gameObject.SetActive(false);
                GameObject.Find("Player1Panel").transform.GetChild(Player1slot1Num).gameObject.SetActive(false);
                GameObject.Find("Player1Panel").transform.GetChild(Player1slot2Num).gameObject.SetActive(false);

            }
            else if(player2Panel.activeSelf)
            {
                slotManager.CheckP2SlotNum();
                gameManager.player2Turn = false;
                gameManager.showingResult = true;
                Player2slot0Num = GameObject.Find("Slot (0)").GetComponent<CardSlot>().slotNum;
                Player2slot1Num = GameObject.Find("Slot (1)").GetComponent<CardSlot>().slotNum;
                Player2slot2Num = GameObject.Find("Slot (2)").GetComponent<CardSlot>().slotNum;
                GameObject.Find("Player1Panel").transform.GetChild(Player2slot0Num).gameObject.SetActive(false);
                GameObject.Find("Player1Panel").transform.GetChild(Player2slot1Num).gameObject.SetActive(false);
                GameObject.Find("Player1Panel").transform.GetChild(Player2slot2Num).gameObject.SetActive(false);
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
