using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlothMiniGame: MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //collision.gameObject.SetActive(false);
            //Destroy(GameObject.FindWithTag("Key"));
            Destroy(gameObject);
            StartCoroutine(LoadSceneCoroutine());

        }
    }

    IEnumerator LoadSceneCoroutine()
    {
        yield return SceneManager.LoadSceneAsync("SlothMini", LoadSceneMode.Additive);

    }
}
