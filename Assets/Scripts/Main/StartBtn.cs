using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartBtn : MonoBehaviour
{
    DataManager data;
    public GameModeBtn gamemode;
    GameManager gameManager;
    public TextMeshProUGUI p1Num, p2Num;

    private void Start() 
    {
        data = DataManager.singleTon;
        gameManager = GameManager.instance;
        ResetNumber();
    }

    public void ResetNumber()
    {
        p1Num.text = gameManager.p1score.ToString();
        p2Num.text = gameManager.p2score.ToString();
    }
    public void LoadGameScene()
    {
        gameManager.multiroundCount++;
        SceneManager.LoadScene("GameScene");
        if(data.saveData.isFirst)
        {
            data.saveData.isFirst = false;
            data.Save();
        }
    }
}
