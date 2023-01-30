using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnim : MonoBehaviour
{
    [SerializeField] InGameManager inGameManager;

    // Start is called before the first frame update
    void Awake()
    {
        if(inGameManager.round == 0)
        {
            StartCoroutine(SizeUp());
        }
    }

    public IEnumerator SizeUp()
    {
        float size = 0f;
        while(size < 1)
        {
            size += 0.01f;
            GetComponent<RectTransform>().localScale = new Vector3(size, size, 1);
            yield return new WaitForSeconds(0.013f);
        }
        GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }
}
