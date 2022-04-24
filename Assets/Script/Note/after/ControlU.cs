using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlU : MonoBehaviour
{
    TimingU timingU;
    NoteLList noteLList;

    // Start is called before the first frame update
    void Start()
    {
        timingU = FindObjectOfType<TimingU>();
        noteLList = FindObjectOfType<NoteLList>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            timingU.CheckTiming();
        }
    }
}
