using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FootBoard : MonoBehaviour
{
    Collider2D col;

    public IEnumerator FadeOut()
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        float alpha = 1f;
        while(alpha > 0)
        {
            alpha -= 0.02f;
            GetComponent<SpriteRenderer>().color = new Color(0,0,0,alpha);
            yield return new WaitForSeconds(0.01f);
        }
        this.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        col = collider;

        if((this.gameObject.CompareTag("plusboard")) && (col.GetComponent<Piece>().board.plusBoardNum == col.GetComponent<Piece>().boardNum))
        {
            StartCoroutine(DelayCheck(col.GetComponent<Piece>(), 1));
            this.GetComponent<AudioSource>().Play();
        }
        else if((this.gameObject.CompareTag("minusboard")) && (col.GetComponent<Piece>().board.minusBoardNum == col.GetComponent<Piece>().boardNum))
        {
            StartCoroutine(DelayCheck(col.GetComponent<Piece>(), -1));
            this.GetComponent<AudioSource>().Play();
        }
    }

    IEnumerator DelayCheck(Piece piece, int plusOrMinus)
    {
        while(piece.runningOnCoroutine)
        {
            yield return null;
        }
        piece.boardNum += plusOrMinus;
        piece.StartCoroutine(col.GetComponent<Piece>().MoveCoroutine());
        StartCoroutine(FadeOut()); 
    }
}
