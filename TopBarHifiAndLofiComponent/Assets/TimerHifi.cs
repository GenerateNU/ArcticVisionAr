using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerHifi : MonoBehaviour
{
  private float startTime;

    // Start is called before the first frame update
    void Start()
    {
      startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
      gameObject.GetComponent<UnityEngine.UI.Text>().text = timerTime();

    }

    string timerTime() {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        float secs = (t % 60);
        string seconds = "";
        if (System.Math.Round(secs) < 10) {
          seconds += "0";
        }
        seconds += secs.ToString("f0");
        return minutes + ":" + seconds;
    }
}
