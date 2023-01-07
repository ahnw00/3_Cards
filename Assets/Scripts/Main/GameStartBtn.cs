using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartBtn : MonoBehaviour
{
    public bool showRules = true; // 게임방법 버튼 눌리면 이거 true로 바꿔줌
    public GameObject gameStartPanel;
    public GameObject fadeinPanel,fadeoutPanel;

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
            fadeoutPanel.SetActive(true);
            fadeoutPanel.GetComponent<Animator>().SetTrigger("FadeOut");
            Invoke("fadeoutFin", 0.8f);
        }
        else
        {
            //게임 방법 패널 setActive true;
        }
    }

    void fadeoutFin()
    {
        //Debug.Log("1초기다림");
        fadeoutPanel.SetActive(false);
        fadeinPanel.SetActive(true);
        fadeinPanel.GetComponent<Animator>().SetTrigger("FadeIn");
        gameStartPanel.SetActive(true);
        Invoke("fadeinStart", 0.8f);
    }

    void fadeinStart()
    {
        fadeinPanel.SetActive(false);
    }
}
