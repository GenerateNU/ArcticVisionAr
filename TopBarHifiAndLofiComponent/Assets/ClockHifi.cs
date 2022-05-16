using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHifi : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      gameObject.GetComponent<UnityEngine.UI.Text>().text = currentTime();
        
    }

    string currentTime () {
      return System.DateTime.UtcNow.ToLocalTime().ToString("hh:mm");
    }
}
