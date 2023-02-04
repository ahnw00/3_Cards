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
    public GameObject Texts;

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
            finalGameEndPanel.SetActive(true);
            Texts.GetComponent<Animator>().SetTrigger("On");
            //TextFade(0, 1.0f, showResultText);
            ResetScore();
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
                finalGameEndPanel.SetActive(true); 
                Texts.GetComponent<Animator>().SetTrigger("On");
                ResetScore();
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
                finalGameEndPanel.SetActive(true); 
                Texts.GetComponent<Animator>().SetTrigger("On");
                ResetScore();
            }
        }
        
    }

    private void Update() {
        if(gameManager.gobackStartScene)
        {
            if(Input.GetMouseButtonDown(0))
            {
                TextFade(1, 0.0f, finalGameEndPanel);
                finalGameEndPanel.SetActive(false);
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

    IEnumerator TextFade(int first, float final, GameObject obj)
    {
        float fadeCount = first;
        while(fadeCount < final)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.001f);
            obj.GetComponent<Image>().color = new Color(0, 0, 0, fadeCount);
        }
    }
}
