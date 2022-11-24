using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurnBtn : MonoBehaviour
{
    GameManager gameManager;
    public GameObject player1Panel, player2Panel;
    SlotManager slotManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.gameManager;
        slotManager = SlotManager.slotManager;
    }

    public void ClickNextTurnBtn()
    {
        /*if(player1Panel.activeSelf)
        {
            slotManager.CheckP1SlotNum();
        }
        else if(player2Panel.activeSelf)
        {
            slotManager.CheckP2SlotNum();
            slotManager.CompareCardNum();
        }*/
        player1Panel.SetActive(false);
        player2Panel.SetActive(true);
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
