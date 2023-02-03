using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ResultPanel : MonoBehaviour
{
    GameManager gameManager;
    InGameManager inGameManager;
    public GameObject finalGameEndPanel;
    [SerializeField] TextMeshProUGUI showResultText;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        inGameManager = InGameManager.instance;
        if(gameManager.gobackStartScene) { ShowFinalResult(); }
    }

    public void ShowFinalResult()
    {
        //글자 등장시킬 때 페이드인 사용해야함
        if(gameManager.gameMode == "singleRound") // 단판인 경우
        {
            if(!inGameManager.winnerCheck) // p1 승리
            {
                showResultText.text = "Player 1 is \n the winner!";
            }
            else
            {
                showResultText.text = "Player 2 is \n the winner!";
            }
            showResultText.text.Replace("\\n", "\n");
            finalGameEndPanel.SetActive(true); ResetScore();
        }
        else if(gameManager.gameMode == "multipleRound") // 멀리라운드인 경우
        {
            int p1win = gameManager.p1score - gameManager.p2score;
            if(gameManager.multiroundCount == 3)
            {
                if(p1win > 0)
                {
                    showResultText.text = "Player 1 is \n the winner!";
                }
                else
                {
                    showResultText.text = "Player 2 is \n the winner!";
                }
                showResultText.text.Replace("\\n", "\n");
                finalGameEndPanel.SetActive(true); ResetScore();
            }
            else if(gameManager.multiroundCount == 2 && p1win != 0)
            {
                if(p1win > 0)
                {
                    showResultText.text = "Player 1 is \n the winner!";
                }
                else
                {
                    showResultText.text = "Player 2 is \n the winner!";
                }
                showResultText.text.Replace("\\n", "\n");
                finalGameEndPanel.SetActive(true); ResetScore();
            }
        }
    }

    public void ResetScore()
    {
        gameManager.p1score = 0;
        gameManager.p2score = 0;
        
        if(gameManager.gameMode == "multipleRound")
        {
            gameManager.multiroundCount = 0;
        }
    }
}
