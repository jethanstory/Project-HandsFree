using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextingInputScr : MonoBehaviour
{
    public GameObject textTestSentCanvas;
    public GameObject textTestRecievedCanvas;

    public float selectedRandNum;
    public float countdownNum;
    // Start is called before the first frame update
    void Start()
    {
        textTestRecievedCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        selectedRandNum = Random.Range(0f, 10.0f);
        countdownNum += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            countdownNum = 0f;
            textTestRecievedCanvas.SetActive(false);
            textTestSentCanvas.SetActive(true);
        }

        if (countdownNum > selectedRandNum)
        {
            textTestRecievedCanvas.SetActive(true);
            textTestSentCanvas.SetActive(false);
        }


    }
}
