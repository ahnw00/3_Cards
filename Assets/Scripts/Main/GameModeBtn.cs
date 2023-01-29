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
        if(gameManager.gameMode == "singleRound")
        {
            this.GetComponent<Image>().sprite = multipleRoundImg;
            gameManager.gameMode = "multipleRound";
        }
        else if(gameManager.gameMode == "multipleRound")
        {
            AlertChangingMode();
            this.GetComponent<Image>().sprite = singleRoundImg;
            gameManager.gameMode = "singleRound";
        }
    }

    public void AlertChangingMode()
    {
        if(gameManager.p1score != 0 || gameManager.p2score != 0)
        {
            alertPanel.SetActive(true);
            gameManager.p1score = 0;
            gameManager.p2score = 0;
            startbtn.ResetNumber();
        }
    }
}
