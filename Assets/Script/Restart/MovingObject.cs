using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    static public MovingObject instance;

    public string currentMapName;

    private BoxCollider2D boxCollider;
    public LayerMask layerMask;

    /*public AudioClip walkSound_1;       // 사운드 파일
    public AudioClip walkSound_2;

    private AudioSource audioSource; */   // 사운드 플레이어

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
        if (instance = null)
        {
            DontDestroyOnLoad(this.gameObject);
            boxCollider = GetComponent<BoxCollider2D>();
            animator = GetComponent<Animator>();
            //audioSource = GetComponent<AudioSource>();
            instance = this;
        }
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

            if (vector.x != 0)      // vector x의 값이 1인 경우  y를 0으로 한다는 코드, 차피 필요 없으니깐
            {                       // 두개 동시에 누르면 애니메이터에 오류가 생김
                vector.y = 0;
            }

            animator.SetFloat("DirX", vector.x);
            animator.SetFloat("DirY", vector.y);

            RaycastHit2D hit;   // A지점에서 B지점으로 레이저를 쐈을때 무사히 맞추면 'Null 값'으로 리턴 중간에 방해물이 맞으면 '방해물 값'이 리턴된다.

            Vector2 start = transform.position;  // A지점 , 캐릭터의 현재 위치 값
            Vector2 end = start + new Vector2(vector.x * speed * walkCount, vector.y * speed * walkCount);    // B지점 , 캐릭터가 이동하고자 하는 위치 값


            boxCollider.enabled = false;
            hit = Physics2D.Linecast(start, end, layerMask);
            boxCollider.enabled = true;

            if (hit.transform != null)
            {
                break;
            }

            animator.SetBool("Walking", true);

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

                /*if(currentwalkCount % 9 == 2)
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
