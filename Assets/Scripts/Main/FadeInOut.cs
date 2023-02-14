using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    public GameObject gameStartPanel;
    // Start is called before the first frame update
    public void EndEvent()
    {
        this.gameObject.SetActive(false);
    }

    public void PanelOn()
    {
        gameStartPanel.SetActive(true);
    }
}
