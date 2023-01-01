using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartBtn : MonoBehaviour
{
    public bool showRules = false; // 게임방법 버튼 눌리면 이거 true로 바꿔줌
    public GameObject gameStartPanel;

    void Start() {
        /*if ('users show rule panel')
        {
            showRules = true;
        }*/
    }

    public void ClickStartBtn()
    {
        if(showRules)
        {
            gameStartPanel.SetActive(true);
        }
        else
        {
            //게임 방법 패널 setActive true;
        }
    }
}
