using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    private void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
