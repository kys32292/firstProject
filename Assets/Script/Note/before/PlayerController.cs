using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Timing timing;

    // Start is called before the first frame update
    void Start()
    {
        timing = FindObjectOfType<Timing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //판정 체크
            timing.CheckTiming();
        }
    }
}
