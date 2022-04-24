using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlR : MonoBehaviour
{
    TimingR timingR;
    NoteLList noteLList;

    // Start is called before the first frame update
    void Start()
    {
        timingR = FindObjectOfType<TimingR>();
        noteLList = FindObjectOfType<NoteLList>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            timingR.CheckTiming();
        }
    }
}
