using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartBtn : MonoBehaviour
{
    public GameModeBtn gamemode;
    GameManager gameManager;
    public TextMeshProUGUI p1Num, p2Num;
    private void Start() {
        gameManager = GameManager.instance;
        p1Num.text = gameManager.p1score.ToString();
        p2Num.text = gameManager.p2score.ToString();
    }
    public void ResetPlayerScore()
    {
        if(gameManager.gameMode == "singleRound") // 단판일때 게임 새로 시작하면 점수 초기화
        {
            gameManager.p1score = 0;
            gameManager.p2score = 0;
        }
        else if(gameManager.gameMode == "multipleRound")
        {
            if(gameManager.multiroundCount == 3) // 3판 모두 끝난 경우
            {
                gameManager.p1score = 0;
                gameManager.p2score = 0;
                gameManager.multiroundCount = 0;
            }
            else if(gameManager.multiroundCount == 2 && gameManager.p1score != gameManager.p2score) // 한쪽이 3판 2선한 경우
            {
                gameManager.p1score = 0;
                gameManager.p2score = 0;
                gameManager.multiroundCount = 0;
            }
            else if(gameManager.multiroundCount == 0) // 이전 게임이 단판 버전이었을 경우
            {
                gameManager.p1score = 0;
                gameManager.p2score = 0;
            }
        }
        p1Num.text = gameManager.p1score.ToString();
        p2Num.text = gameManager.p2score.ToString();
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
