using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurnBtn : MonoBehaviour
{
    public GameObject player1panel, player2panel;
    public SlotManager slotManager;
    // Start is called before the first frame update
    void Start()
    {
        slotManager = FindObjectOfType<SlotManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestBtn() // for slotManger func test. do not discard
    {
        if(player1panel.activeSelf)
        {
            slotManager.CheckP1SlotNum();
        }
        else if(player2panel.activeSelf)
        {
            slotManager.CheckP2SlotNum();
        }
    }
}
