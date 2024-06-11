using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using FantomLib;

public class ChangeColorProximity : MonoBehaviour
{
    public Color colorFar;
    public Color colorNear;
    public Text proximityMsg, accelerationMsg, accelerometerThresholdMsg;
    public VibratorController vibratorControl;
    public float accelerometerThreshold;
    public Animator animator;

    public void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        vibratorControl = FindObjectOfType<VibratorController>();
    }

    public void Check(float value1)
    {
        if (value1 > 1f)
        {
            Far();
        }
        else
        {
            Near();
        }
        proximityMsg.text = value1.ToString("00.00");
    }

    public void Far()
    {
        Camera.main.backgroundColor = colorFar;
    }

    public void Near()
    {
        Camera.main.backgroundColor = colorNear;
    }

    public void Update()
    {
        accelerometerThresholdMsg.text = accelerometerThreshold.ToString("000.00");
        float accel = (Input.acceleration.magnitude) * 100f;
        accelerationMsg.text = accel.ToString("000.00");
        if (accel > accelerometerThreshold)
        {
            vibratorControl.StartVibrator();
            animator.SetFloat("moving", 2f);
        }
        else
        {
            animator.SetFloat("moving", 0f);
        }

    }

    public void SetThreshold(float newValue)
    {
        accelerometerThreshold = newValue;
    }
}
