using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartBtn : MonoBehaviour
{
    DataManager data;
    [SerializeField] GameObject howToPlayPanel;
    public GameObject gameStartPanel;
    public GameObject fadeinPanel,fadeoutPanel;

    void Start() {
        data = DataManager.singleTon;
    }

    public void ClickStartBtn()
    {
        if(!data.saveData.isFirst)
        {
            fadeoutPanel.SetActive(true);
            fadeoutPanel.GetComponent<Animator>().SetTrigger("FadeOut");
            Invoke("fadeoutFin", 0.8f);
        }
        else
        {
            howToPlayPanel.SetActive(true);
            gameStartPanel.SetActive(true);
            data.saveData.isFirst = false;
            data.Save();
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
