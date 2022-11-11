using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 게임 플로우 관리
// 슬롯 리스트 관리
// 승부 판별

public class GameManager : MonoBehaviour
{
    [HideInInspector] public bool playerArrivedEndPoint = false;
    [HideInInspector] public bool player1Turn = false;
    [HideInInspector] public bool player2Turn = false;
    int round = 0;
    [SerializeField] Image cuttonImage;

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

            cuttonImage.enabled = true;

            while(player2Turn)
            {
                yield return null;
            }
        }
    }
}
