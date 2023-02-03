using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool firstChange = false; //false면 p1이 선공, true면 p2가 선공
    public int p1score, p2score = 0;
    public string gameMode = "singleRound"; //단판 : "singleRound", 삼세판 : "multipleRound"
    public int multiroundCount = 0;
    public bool gobackStartScene = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
