using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnim : MonoBehaviour
{
    float screenHeight;
    float cameraSize;

    void Awake()
    {
        screenHeight = Screen.height;
        cameraSize = screenHeight/100 * 1/2;
        this.GetComponent<Camera>().orthographicSize = cameraSize;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ZoomIn());
    }

    public IEnumerator ZoomIn()
    {
        float size = cameraSize * 1.8f;
        while(size > cameraSize)
        {
            size -= 0.05f;
            GetComponent<Camera>().orthographicSize = size;
            yield return null;
        }
        GetComponent<Camera>().orthographicSize = cameraSize;
    }
}
