using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameModeBtn : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] Sprite singleRoundImg, multipleRoundImg;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        
        if(gameManager.gameMode == "singleRound")
        {
            this.GetComponent<Image>().sprite = singleRoundImg;
        }
        else if(gameManager.gameMode == "multipleRound")
        {
            this.GetComponent<Image>().sprite = multipleRoundImg;
        }
    }
}
