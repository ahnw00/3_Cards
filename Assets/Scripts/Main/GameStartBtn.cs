using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartBtn : MonoBehaviour
{
    DataManager data;
    [SerializeField] GameObject howToPlayPanel;
    public GameObject gameStartPanel;
    public GameObject fadePanel;

    void Start() {
        data = DataManager.singleTon;
    }

    public void ClickStartBtn()
    {
        if(!data.saveData.isFirst)
        {
            fadePanel.SetActive(true);
        }
        else
        {
            howToPlayPanel.SetActive(true);
            gameStartPanel.SetActive(true);
            data.saveData.isFirst = false;
            data.Save();
        }
    }
}
