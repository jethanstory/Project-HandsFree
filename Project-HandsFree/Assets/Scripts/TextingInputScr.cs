using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextingInputScr : MonoBehaviour
{
    public GameObject textTestSentCanvas;
    public GameObject textTestRecievedCanvas;
    public GameObject textRecievedSound;
    public GameObject textSentSound;
    public GameObject fpsPlayer;

    public bool hasResponded = false;
    public bool isLooking = false;

    public float selectedRandNum;
    public float countdownNum;
    // Start is called before the first frame update
    void Start()
    {
        textTestRecievedCanvas.SetActive(true);
        selectedRandNum = Random.Range(3f, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // selectedRandNum = Random.Range(3f, 200.0f);
        countdownNum += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && fpsPlayer.GetComponent<LookingAtPhoneScr>().isLooking && !hasResponded)
        {
            // selectedRandNum = Random.Range(0f, 50.0f);
            selectedRandNum = Random.Range(0f, 10.0f);
            textSentSound.SetActive(false);
            textSentSound.SetActive(true);
            countdownNum = 0f;
            textTestRecievedCanvas.SetActive(false);
            textTestSentCanvas.SetActive(true);
            hasResponded = true;
        }

        if (countdownNum > selectedRandNum && hasResponded)
        {
            // selectedRandNum = Random.Range(0f, 50.0f);
            textRecievedSound.SetActive(false);
            textRecievedSound.SetActive(true);
            textTestRecievedCanvas.SetActive(true);
            textTestSentCanvas.SetActive(false);
            hasResponded = false;
        }


    }

    
}
