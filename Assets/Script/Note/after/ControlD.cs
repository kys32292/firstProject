using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlD : MonoBehaviour
{
    TimingD timingD;
    NoteLList noteLList;

    // Start is called before the first frame update
    void Start()
    {
        timingD = FindObjectOfType<TimingD>();
        noteLList = FindObjectOfType<NoteLList>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            timingD.CheckTiming();
        }
    }
}
