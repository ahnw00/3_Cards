using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FootBoard : MonoBehaviour
{
    
    public IEnumerator FadeOut()
    {
        float alpha = 0.0f;
        while(alpha < 1)
        {
            alpha += 0.02f;
            this.gameObject.GetComponent<Image>().color = new Color(0,0,0,alpha);
            yield return new WaitForSeconds(0.01f);
        }
        this.gameObject.SetActive(false);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.GetComponent<Board>().plusBoardNum);
        Debug.Log(col.GetComponent<Piece>().boardNum); 
        if(col.GetComponent<Board>().plusBoardNum == col.GetComponent<Piece>().boardNum)
        {
            col.GetComponent<Piece>().boardNum += 1;
            col.GetComponent<Piece>().StartCoroutine(col.GetComponent<Piece>().MoveCoroutine());
        }
        else if(col.GetComponent<Board>().minusBoardNum == col.GetComponent<Piece>().boardNum)
        {
            col.GetComponent<Piece>().boardNum -= 1;
            col.GetComponent<Piece>().StartCoroutine(col.GetComponent<Piece>().MoveCoroutine());
        }
        StartCoroutine(FadeOut()); 
    }

}
