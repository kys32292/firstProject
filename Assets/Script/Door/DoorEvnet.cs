using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEvnet : MonoBehaviour
{

    //public Animator ani;

    //[Tooltip("UP,DOWN,LEFT,RIGHT")]
    //public string direction;    // 캐릭터가 바라보고 있는 방향

    //private Vector2 vector;

    //[Tooltip("문이 있으면 : ture, 문이 없으면 : false")]
    //public bool Door; //문이 있냐 없냐 체크

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
                Debug.Log("플레이어 인식 완료");
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
