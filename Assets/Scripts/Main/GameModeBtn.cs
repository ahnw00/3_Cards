using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameModeBtn : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] Sprite singleRoundImg, multipleRoundImg;
    [SerializeField] GameObject logo;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        logo.GetComponent<Animator>().SetTrigger("MoveStart");
        
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
