using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlL : MonoBehaviour
{   

    TimingL timingL;
    NoteLList noteLList;

    // Start is called before the first frame update
    void Start()
    {
        timingL = FindObjectOfType<TimingL>();
        noteLList = FindObjectOfType<NoteLList>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            timingL.CheckTiming();
        }
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("´­¸²");
            //timingL.CheckTiming();
            noteLList.CheckTiming();
        }
    }*/
}
