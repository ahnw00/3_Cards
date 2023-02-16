using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameModeBtn : MonoBehaviour
{
    GameManager gameManager;
    public StartBtn startbtn;
    [SerializeField] Sprite singleRoundImg, multipleRoundImg;
    public GameObject alertPanel;

    void Start()
    {
        gameManager = GameManager.instance;
        if(gameManager.gameMode == "multipleRound")
        {
            this.GetComponent<Image>().sprite = multipleRoundImg;
        }
    }

    // Start is called before the first frame update
    public void ChangeMode()
    {
        gameManager.multiroundCount = 0;
        if(gameManager.gameMode == "singleRound")
        {
            this.GetComponent<Image>().sprite = multipleRoundImg;
            gameManager.gameMode = "multipleRound";
        }
        else if(gameManager.gameMode == "multipleRound")
        {
            if(gameManager.p1score == 0 && gameManager.p2score == 0)
            {
                gameManager.p1score = 0;
                gameManager.p2score = 0;
                startbtn.ResetNumber();
                this.GetComponent<Image>().sprite = singleRoundImg;
                gameManager.gameMode = "singleRound";
            }
            else if(gameManager.p1score != 0 || gameManager.p2score != 0){alertPanel.SetActive(true); }
        }
    }

    public void AcceptChangeMode()
    {
        gameManager.p1score = 0;
        gameManager.p2score = 0;
        startbtn.ResetNumber();
        this.GetComponent<Image>().sprite = singleRoundImg;
        gameManager.gameMode = "singleRound";
        alertPanel.SetActive(false);  
    }
}
