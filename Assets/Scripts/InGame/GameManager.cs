using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 게임 플로우 관리
// 슬롯 리스트 관리
// 승부 판별

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [HideInInspector] public bool playerArrivedEndPoint = false;
    [HideInInspector] public bool player1Turn = false;
    [HideInInspector] public bool player2Turn = false;
    [HideInInspector] public int round = 0;
    public GameObject cutton;

    // void Awake()
    // {
    //     if (null == instance)
    //     {
    //         instance = this;
    //         DontDestroyOnLoad(this.gameObject);
    //     }
    //     else
    //     {
    //         Destroy(this.gameObject);
    //     }
    // }

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TurnManager());
        player1Turn = true;
    }

    IEnumerator TurnManager()
    {
        yield return null;
        while(!playerArrivedEndPoint)
        {
            while(player1Turn)
            {
                yield return null;
            }

            cutton.SetActive(true);

            while(player2Turn)
            {
                yield return null;
            }
        }
    }
}
