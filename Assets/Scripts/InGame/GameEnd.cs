using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    public void GetResult()
    {

    }

    public void Touch()
    {
        if(gameManager.gameMode == "singleRound")
        {

        }
        else if(gameManager.gameMode == "multipleRound")
        {

        }
    }
}
