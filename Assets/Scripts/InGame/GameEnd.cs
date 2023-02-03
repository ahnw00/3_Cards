using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameEnd : MonoBehaviour
{
    GameManager gameManager;
    InGameManager inGameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        inGameManager = InGameManager.instance;
    }

    public void ShowResult()
    {
        // 1 구름 애니메이션 켜주기
        // 2 글자 페이드인
        // 3 클릭 받고 글자 페이드 아웃
        // 4 구름 애니메이션 끝나는 부분 
        // 5 애니메이션 끝나면 gotostartscene 함수 호출
    }
    
    public void GotoStartScene()
    {
        gameManager.gobackStartScene = true;
        SceneManager.LoadScene("StartScene");
    }
}
