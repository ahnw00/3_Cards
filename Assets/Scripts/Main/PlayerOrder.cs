using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerOrder : MonoBehaviour
{
    GameManager gameManager;
    public GameObject ChangeBtn, StartBtn;
    public TextMeshProUGUI p1, p2;
    public bool clickCBtn = false;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    public void ChangeOrder()
    {
        if(!clickCBtn) // p1이 선공
        {
            clickCBtn = true; // 버튼을 누름
            gameManager.firstChange = true; //p1이 후공
            p1.text = "Last";
            p2.text = "First";
        }
        else // p2가 선공
        {
            clickCBtn = false;
            gameManager.firstChange = false;
            p1.text = "First";
            p2.text = "Last";
        }
    }

    public void GameStartBtn()
    {
        //씬매니저사용?
    }
}
