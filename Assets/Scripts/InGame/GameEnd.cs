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
    [SerializeField] GameObject endText, cuttonCover, cotton;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        inGameManager = InGameManager.instance;
    }

    IEnumerator delayTime()
    {
       yield return new WaitForSeconds(2.5f);
    }

    public void ShowResult()
    {
        this.gameObject.SetActive(true);
        //delayTime();
        cuttonCover.SetActive(false);
        // 3 클릭 받고 글자 페이드 아웃
        // 4 구름 애니메이션 끝나는 부분 
        // 5 애니메이션 끝나면 gotostartscene 함수 호출
    }

    public void GotoStartScene()
    {
        this.gameObject.SetActive(false);
        SceneManager.LoadScene("StartScene");
    }

    public void ChangeAudioClip(AudioClip clip)
    {
        this.GetComponent<AudioSource>().clip = clip;
        this.GetComponent<AudioSource>().Play();
    }
}
