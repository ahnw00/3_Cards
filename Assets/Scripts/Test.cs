using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void testing()
    {
        Transform p2 = player2.GetComponent<Transform>();
        p2.position = new Vector3(6.6f, 3.2f, -1f);
        player2.gameObject.GetComponent<Piece>().boardNum = 10;
    }
}