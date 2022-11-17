using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurnBtn : MonoBehaviour
{
    public GameObject Player1Panel, Player2Panel;
    public SlotManager slotManager;
    // Start is called before the first frame update
    void Start()
    {
        slotManager = FindObjectOfType<SlotManager>();
    }

    public void ClickNextTurnBtn()
    {
        if(Input.GetMouseButtonDown(0))
        {
            cuttonImage.SetActive(true); // 커튼 이미지의 inspector에 접근하는 법? serializedfield라 접근이 안 되나?
            Player1Panel.SetActive(false);
            Player2Panel.SetActive(true);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestBtn() // for slotManger func test. do not discard
    {
        if(Player1Panel.activeSelf)
        {
            slotManager.CheckP1SlotNum();
        }
        else if(Player2Panel.activeSelf)
        {
            slotManager.CheckP2SlotNum();
        }
    }
}
