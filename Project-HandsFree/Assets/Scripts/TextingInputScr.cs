using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextingInputScr : MonoBehaviour
{
    public GameObject textTestSentCanvas;
    public GameObject textTestRecievedCanvas;
    // Start is called before the first frame update
    void Start()
    {
        textTestRecievedCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            textTestRecievedCanvas.SetActive(true);
            textTestSentCanvas.SetActive(true);
        }
    }
}
