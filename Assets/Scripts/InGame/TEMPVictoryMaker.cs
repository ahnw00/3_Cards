using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMPVictoryMaker : MonoBehaviour
{
    [HideInInspector]int player1piece = 0;
    [HideInInspector]int player2piece = 0;


    public void Random_victory_determiner()
    {
        for(int i=1 ; i<4 ; i++)
        {

            int player1CardNum = (int)Random.Range(0, 6);
            int player2CardNum = (int)Random.Range(0, 6);

            if(player1CardNum - player2CardNum < 0)
            {
                player2piece += 1;
            }
            else if(player1CardNum - player2CardNum > 0 )
            {
                player1piece += 1;
            }
            Debug.Log("플레이어1의 값: " +player1CardNum + " 플레이어2의 값: "+player2CardNum );         
            
        
        }

        Debug.Log("결과: " + "플레이어1이 움직일 수: " +player1piece + " 플레이어2가 움질일 수: "+player2piece);
        GameObject.FindWithTag("Player1").GetComponent<Piece>().MovePiecePos(player1piece);
        GameObject.FindWithTag("Player2").GetComponent<Piece>().MovePiecePos(player2piece);

        player1piece = 0;
        player2piece = 0;

    }
}
