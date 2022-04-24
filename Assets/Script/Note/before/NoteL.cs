using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteL : MonoBehaviour
{

    //public GameObject note;
    //[SerializeField] GameObject obj;
    public List<GameObject> boxNoteList = new List<GameObject>();

    LTiming lTiming;


    // Start is called before the first frame update
    void Start()
    {
        lTiming = FindObjectOfType<LTiming>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            //Destroy(obj);
            Debug.Log("눌림");
            //lTiming.CheckTiming();
            //Destroy(GameObject.FindWithTag("Note"));

            /*for (int i=0; i<boxNoteList.Count; i++)
            {
                Destroy(boxNoteList[i]);
                boxNoteList.RemoveAt(i);
            }
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Destroy(obj);
            Debug.Log("눌림");
            //Destroy(GameObject.FindWithTag("Note"));
            for (int i=0; i<boxNoteList.Count; i++)
            {
                Destroy(boxNoteList[i]);
                boxNoteList.RemoveAt(i);
            }
        }
    }
}
