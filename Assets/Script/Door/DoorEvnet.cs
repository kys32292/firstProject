using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEvnet : MonoBehaviour
{

    //public Animator ani;

    //[Tooltip("UP,DOWN,LEFT,RIGHT")]
    //public string direction;    // ĳ���Ͱ� �ٶ󺸰� �ִ� ����

    //private Vector2 vector;

    //[Tooltip("���� ������ : ture, ���� ������ : false")]
    //public bool Door; //���� �ֳ� ���� üũ

    //public bool conltrol = false;
    public bool conltrol = true;

    // Start is called before the first frame update
    void Start()
    {
        //ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        /*if (Door)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                if (Input.GetKey(KeyCode.F))
                {
                    ani.SetBool("Open", true);
                }
            }
        }*/
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.F))
            {
                Debug.Log("�÷��̾� �ν� �Ϸ�");
                //ani.SetBool("Open", true);
                //conltrol = true;
                conltrol = false;
                //Debug.Log(conltrol);
            }
            else
            {
                conltrol = true;
            }
        }
        //conltrol = false;
    }
}
