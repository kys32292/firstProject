using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAction : MonoBehaviour
{
    public Animator ani;

    [Tooltip("UP,DOWN,LEFT,RIGHT")]
    public string direction;    // ĳ���Ͱ� �ٶ󺸰� �ִ� ����

    private Vector2 vector; //getfloat("dirX")�� �ҷ����� ���� ����

    [Tooltip("���� ������ : ture, ���� ������ : false")]
    public bool door; //���� �ֳ� ���� üũ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
