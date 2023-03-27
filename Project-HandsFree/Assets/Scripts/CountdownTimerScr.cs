using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimerScr : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;

    public GameObject originObject;
    //public GameObject carObject;
    public GameObject LoseCanvas;
    public GameObject LoseText;

    private void Start()
    {
        // Starts the timer automatically
        //timerIsRunning = true;
    }
    void Update()
    {
        if (originObject.GetComponent<TextingInputScr>().hasResponded)
        {
            timerIsRunning = false;
            //timeRemaining = Random.Range(0f, 10.0f);
            timeRemaining = 10;
        }

        if (!originObject.GetComponent<TextingInputScr>().hasResponded)
        {
            timerIsRunning = true;
        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                LoseCanvas.SetActive(true);
                LoseText.SetActive(true);
                Time.timeScale = 0;
                //carObject.GetComponent<CarUserControl>().enabled = false;
                //GameObject.Find("CartoonSportCar").GetComponent<CarUserControl>().enabled = false;

            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
