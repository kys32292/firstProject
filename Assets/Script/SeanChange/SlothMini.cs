using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlothMini : MonoBehaviour
{

    private bool flag;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.SetActive(false);
        }
    }*/

    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (!flag && Input.GetKey(KeyCode.Space))
        {
            Debug.Log("충돌일어남");
            //Destroy(this.gameObject);
            StartCoroutine(LoadSceneCoroutine());
            flag = true;
        }
    }*/

    /*IEnumerator LoadSceneCoroutine()
    {
        yield return SceneManager.LoadSceneAsync("New Scene", LoadSceneMode.Additive);

    }*/
}
