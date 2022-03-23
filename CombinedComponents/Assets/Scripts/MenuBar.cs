using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class MenuBar : MonoBehaviour
{    
    public float batteryLevel = 0.0f;
    public int bluetoothConnected = 0;
    public string temperature = "";
    public string time = "";
    public string userName = "";


    [Header("UI")]

    // public GameObject batteryObj;
    // public GameObject bluetoothObj;
    // public GameObject temperatureObj;
    // public GameObject timeObj;
    // public GameObject userNameObj;

    public Image batBar1;
    public Image batBar2;
    public Image batBar3;
    public Image batBar4;

    public Image btConnectedImg; 
    public Image noBtConnectedImg;

    public Text temperatureText;

    public Text timeText;

    public Text userNameText;

    private void Update()
    {   
        // Handle battery level
        if (batBar1 != null)
        {
          if (batteryLevel == 0.0f)
          {
              batBar1.enabled = false;
              batBar2.enabled = false;
              batBar3.enabled = false;
              batBar4.enabled = false;
          }
          else if (batteryLevel  > 0.75f) {
              batBar1.enabled = true;
              batBar2.enabled = true;
              batBar3.enabled = true;
              batBar4.enabled = true;
          }
          else if (batteryLevel <= 0.75f && batteryLevel > 0.5f) {
              batBar1.enabled = true;
              batBar2.enabled = true;
              batBar3.enabled = true;
              batBar4.enabled = false;
          }
          else if (batteryLevel <= 0.5f && batteryLevel > 0.25f) {
              batBar1.enabled = true;
              batBar2.enabled = true;
              batBar3.enabled = false;
              batBar4.enabled = false;
          }
          else if (batteryLevel <= 0.25f && batteryLevel > 0.0f) {
              batBar1.enabled = true;
              batBar2.enabled = false;
              batBar3.enabled = false;
              batBar4.enabled = false;
          }
        }

        // Handle bluetooth connection
        if (btConnectedImg != null)
        {
          if (bluetoothConnected == 1)
          {
              btConnectedImg.enabled = true;
              noBtConnectedImg.enabled = false;
          }
          else
          {
              btConnectedImg.enabled = false;
              noBtConnectedImg.enabled = true;
          }
        }

        // Handle temperature
        if (temperatureText != null)
        {
          temperatureText.text = temperature;
        }

        // Handle time
        if (timeText != null)
        {
          timeText.text = time;
        }

        // Handle user name
        if (userNameText != null)
        {
          userNameText.text = userName;
        }
    }
}