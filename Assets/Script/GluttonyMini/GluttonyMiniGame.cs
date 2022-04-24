using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GluttonyMiniGame : MonoBehaviour
{
    [SerializeField]
    private GameObject Apple;

    // Start is called before the first frame update
    void Start()
    {
        //CreateApple();
        StartCoroutine(CreateAppleRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CreateAppleRoutine()
    {
        while (true)
        {
            CreateApple();
            yield return new WaitForSeconds(1);
        }
    }


    private void CreateApple()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3( UnityEngine.Random.Range(0.0f,1.0f),1.1f,0));
        pos.z = 0.0f;
        Instantiate(Apple, pos, Quaternion.identity);
    }
}
