using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeValue = 60;
    public Text timeText;

    //public timesup = false;

    // Update is called once per frame
    void Update()
    {
        if (timeValue >0) {
            timeValue -= Time.deltaTime;
        }
        else {
            timeValue = 0;

        }
        DisplayTime(timeValue);
    }

    void DisplayTime (float timeToDisplay) {
        if(timeToDisplay < 0) {
            timeToDisplay = 0;
        } 
        float minutes = Mathf.FloorToInt(timeToDisplay/60);
        float seconds = Mathf.FloorToInt(timeToDisplay%60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public bool Timesup() {
        if(timeValue <=0) {
            Debug.Log("Waktu habis habis");
            return true;
        }
        else {
            return false;
        }
    }
}
