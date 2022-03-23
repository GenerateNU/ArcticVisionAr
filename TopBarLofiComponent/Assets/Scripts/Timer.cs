using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer: MonoBehaviour
{
    public Text timerText;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        float secs = (t % 60);
        string seconds = "";
        if (Math.Round(secs) < 10) {
          seconds += "0";
        }
        seconds += secs.ToString("f0");
    // .ToString("f0");
        timerText.text = minutes + ":" + seconds;
    }
}
