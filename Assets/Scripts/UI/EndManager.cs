using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManager : MonoBehaviour
{
    public GameObject exitAlertpanel;

    public void GoAway()
    {
        Application.Quit();
    }


    public void EndAlert()
    {
        if(exitAlertpanel.activeSelf)
        {
            exitAlertpanel.SetActive(false);
        }
        else
        {
            exitAlertpanel.SetActive(true);
        }
        
    }
}
