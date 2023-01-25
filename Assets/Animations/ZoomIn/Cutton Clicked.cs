using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CuttonClicked : MonoBehaviour
{

    private Animator animator;

    private void Awake()
    {
        GameObject cutton = null;
        animator = GetComponent<Animator>();
        cutton = GameObject.Find("Cutton");

        if (cutton.activeSelf == true)
        {
            animator.SetBool("Cutton Clicked", false);
        }
        else if (cutton.activeSelf == false)
        {
            animator.SetBool("Cutton Clicked", true);
        }
    
    }
}
