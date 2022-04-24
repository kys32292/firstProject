using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{

    private BoxCollider2D boxCollider;
    public LayerMask layerMask;

    /*public AudioClip walkSound_1;       // ���� ����
    public AudioClip walkSound_2;

    private AudioSource audioSource;*/    // ���� �÷��̾�

    public string walkSound_1;       // ���� ����
    public string walkSound_2;
    public string walkSound_3;
    public string walkSound_4;

    private AudioManager theAudio;

    public float speed;

    private Vector3 vector;

    public float runSpeed;
    private float applyRunSpeed;
    private bool applyRunFlag = false;

    public int walkCount;
    private int currentwalkCount;

    private bool canMove = true;

    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        //audioSource = GetComponent<AudioSource>();
        theAudio = FindObjectOfType<AudioManager>();
    }

    IEnumerator MoveCoroutine()
    {
        while (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                applyRunSpeed = runSpeed;
                applyRunFlag = true;
            }
            else
            {
                applyRunSpeed = 0;
                applyRunFlag = false;
            }

            vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);

            if (vector.x != 0)
            {
                vector.y = 0;
            }

            animator.SetFloat("DirX", vector.x);
            animator.SetFloat("DirY", vector.y);

            RaycastHit2D hit;   // A�������� B�������� �������� ������ ������ ���߸� 'Null ��'���� ���� �߰��� ���ع��� ������ '���ع� ��'�� ���ϵȴ�.

            Vector2 start = transform.position;  // A���� , ĳ������ ���� ��ġ ��
            Vector2 end = start + new Vector2(vector.x * speed * walkCount, vector.y * speed * walkCount);    // B���� , ĳ���Ͱ� �̵��ϰ��� �ϴ� ��ġ ��


            boxCollider.enabled = false;
            hit = Physics2D.Linecast(start, end, layerMask);
            boxCollider.enabled = true;

            if (hit.transform != null)
            {
                break;
            }

            animator.SetBool("Walking", true);

            int temp = Random.Range(1, 4);
            switch (temp)
            {
                case 1:
                    theAudio.Play(walkSound_1);
                    break;

                case 2:
                    theAudio.Play(walkSound_2);
                    break;

                case 3:
                    theAudio.Play(walkSound_3);
                    break;

                case 4:
                    theAudio.Play(walkSound_4);
                    break;
            }

            while (currentwalkCount < walkCount)
            {

                if (vector.x != 0)
                {
                    transform.Translate(vector.x * (speed + applyRunSpeed), 0, 0);
                }
                else if (vector.y != 0)
                {
                    transform.Translate(0, vector.y * (speed + applyRunSpeed), 0);
                }
                if (applyRunFlag == true)
                {
                    currentwalkCount++;
                }
                currentwalkCount++;
                yield return new WaitForSeconds(0.01f);

                /*if (currentwalkCount % 9 == 2)
                {
                    int temp = Random.Range(1, 2);
                    switch (temp)
                    {
                        case 1:
                            audioSource.clip = walkSound_1;
                            audioSource.Play();
                            break;

                        case 2:
                            audioSource.clip = walkSound_2;
                            audioSource.Play();
                            break;
                    }
                }*/

            }
            currentwalkCount = 0;

        }

        canMove = true;
        animator.SetBool("Walking", false);

    }


    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                canMove = false;
                StartCoroutine(MoveCoroutine());
            }
        }

    }
}
