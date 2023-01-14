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
        this.GetComponent<Animator>().SetTrigger("OnClick");
        if(inGameManager.player1Turn)
        {
            player1Panel.SetActive(true);
            slotManager.ResetCardDeck(slotManager.p1);
        }
        else if(inGameManager.player2Turn)
        {
            player2Panel.SetActive(true);
            slotManager.ResetCardDeck(slotManager.p2);
        }
        else if(!inGameManager.player1Turn && !inGameManager.player2Turn && !inGameManager.showingResult)
        {
            inGameManager.showingResult = true;
        }
    }

    public void SetOff()
    {
        if(!inGameManager.player1Turn && !inGameManager.player2Turn && inGameManager.showingResult)
        {
            slotManager.CompareCardNum();
        }
        this.gameObject.SetActive(false);
    }
}