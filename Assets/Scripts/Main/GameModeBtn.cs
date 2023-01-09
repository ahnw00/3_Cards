using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameModeBtn : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] Sprite singleRoundImg, multipleRoundImg;

    void Start()
    {
        gameManager = GameManager.instance;
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
            this.GetComponent<Image>().sprite = singleRoundImg;
            gameManager.gameMode = "singleRound";
        }
    }
}
