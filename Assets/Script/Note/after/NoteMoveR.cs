using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMoveR : MonoBehaviour
{
    public float noteSpeed = 300;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Vector3.right * noteSpeed * Time.deltaTime;
    }
}
