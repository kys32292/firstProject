using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject target;       //ī�޶� ���� ���
    public float moveSpeed;         //ī�޶� �ӵ�
    private Vector3 targetPosition;  //����� ��ġ��

    public static CameraMove Instance;
    public Color TeamColor;

    public BoxCollider2D bound;

    private Vector3 minBound;
    private Vector3 maxBound;   // �ڽ� �ݶ��̴� ������ �ּ� �ִ� X,Y,Z���� ����

    private float halfHeith;
    private float halfWidth;    // ī�޶��� �ݳʺ�, �ݳ��� ���� ���� ����

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

            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime); //1�ʿ� moveSpeed ��ŭ �̵�

            float clampedX = Mathf.Clamp(this.transform.position.x, minBound.x + halfWidth, maxBound.x - halfHeith);
            float clampedY = Mathf.Clamp(this.transform.position.y, minBound.y + halfHeith, maxBound.y - halfWidth);

            this.transform.position = new Vector3(clampedX, clampedY, this.transform.position.z);
        }


    }
}
