using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject target;       //카메라가 따라갈 대상
    public float moveSpeed;         //카메라 속도
    private Vector3 targetPosition;  //대상의 위치값

    public static CameraMove Instance;
    public Color TeamColor;

    public BoxCollider2D bound;

    private Vector3 minBound;
    private Vector3 maxBound;   // 박스 콜라이더 영역의 최소 최대 X,Y,Z값을 지님

    private float halfHeith;
    private float halfWidth;    // 카메라의 반너비, 반높이 값을 지닐 변수

    private Camera theCamera;   


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        theCamera = GetComponent<Camera>();
        minBound = bound.bounds.min;
        maxBound = bound.bounds.max;
        halfHeith = theCamera.orthographicSize;
        halfWidth = halfHeith * Screen.width / Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        if(target.gameObject != null)
        {
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime); //1초에 moveSpeed 만큼 이동

            float clampedX = Mathf.Clamp(this.transform.position.x, minBound.x + halfWidth, maxBound.x - halfHeith);
            float clampedY = Mathf.Clamp(this.transform.position.y, minBound.y + halfHeith, maxBound.y - halfWidth);

            this.transform.position = new Vector3(clampedX, clampedY, this.transform.position.z);
        }


    }
}
