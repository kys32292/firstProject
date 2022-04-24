using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAni : MonoBehaviour
{
    public DoorAni instance;
    DoorEvnet doorEvent;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (doorEvent.conltrol == false)
        {
            Debug.Log("True 인식 완료");
            animator.SetBool("Open", true);
        }
        else
        {
            animator.SetBool("Nomal", false);
        }*/
    }
}
