using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAction : MonoBehaviour
{
    public Animator ani;

    [Tooltip("UP,DOWN,LEFT,RIGHT")]
    public string direction;    // 캐릭터가 바라보고 있는 방향

    private Vector2 vector; //getfloat("dirX")를 불러오기 위한 변수

    [Tooltip("문이 있으면 : ture, 문이 없으면 : false")]
    public bool door; //문이 있냐 없냐 체크

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
