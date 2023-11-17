using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTimer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;
    public UnityEngine.UI.Text TimerTxt;

    void Start()
    {
        TimerOn = true;   
    }

    
    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else {
                Debug.Log("Time over");
                TimeLeft = 0;
                TimerOn = false;

            
            }
        }
    }
    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00 }", minutes, seconds);
    }

    private void OnMouseDown()
    {
        TimeLeft = 0;
    }
}

