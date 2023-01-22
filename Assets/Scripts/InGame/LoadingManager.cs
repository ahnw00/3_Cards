using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingManager : MonoBehaviour
{
    [SerializeField] Text[] resultText;  
    [SerializeField] GameObject cuttonCover;  
    SlotManager slotManager;

    void Start()
    {
        slotManager = SlotManager.instance;
    }

    public void LoadingEndEvent()
    {
        cuttonCover.SetActive(false);
    }

    public void PlayAudio()
    {
        this.GetComponent<AudioSource>().Play();
    }

    public void AnimationEvent()
    {
        for(int i = 0; i < 3; i++)
        {
            if(slotManager.player1Card[i] > slotManager.player2Card[i])
            {
                resultText[i].text = "플레이어1 승리";
            }
            else if(slotManager.player1Card[i] < slotManager.player2Card[i])
            {
                resultText[i].text = "플레이어2 승리";
            }
            else
            {
                resultText[i].text = "무승부";
            }
        }
    }
}
