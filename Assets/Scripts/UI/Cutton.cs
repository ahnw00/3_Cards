using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutton : MonoBehaviour
{
    GameManager gameManager;
    SlotManager slotManager;
    GameObject player1Panel;
    GameObject player2Panel;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        slotManager = SlotManager.instance;
        player1Panel = gameManager.player1Panel;
        player2Panel = gameManager.player2Panel;
    }

    public void ChangeTurn()
    {
        if(gameManager.player1Turn && !gameManager.showingResult)
        {
            player1Panel.SetActive(true);
        }
        else if(gameManager.player2Turn)
        {
            player2Panel.SetActive(true);
        }
        else if(gameManager.showingResult)
        {
            slotManager.CompareCardNum();
        }
    }
}
