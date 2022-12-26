using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutton : MonoBehaviour
{
    InGameManager inGameManager;
    SlotManager slotManager;
    GameObject player1Panel;
    GameObject player2Panel;

    // Start is called before the first frame update
    void Start()
    {
        inGameManager = InGameManager.instance;
        slotManager = SlotManager.instance;
        player1Panel = inGameManager.player1Panel;
        player2Panel = inGameManager.player2Panel;
    }

    public void ChangeTurn()
    {
        if(inGameManager.player1Turn && !inGameManager.showingResult)
        {
            player1Panel.SetActive(true);
            slotManager.ResetCard1Deck();
        }
        else if(inGameManager.player2Turn)
        {
            player2Panel.SetActive(true);
            slotManager.ResetCard2Deck();
        }
        else if(inGameManager.showingResult)
        {
            slotManager.CompareCardNum();
        }
    }
}
