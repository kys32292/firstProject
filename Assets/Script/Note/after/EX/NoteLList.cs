using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteLList : MonoBehaviour
{

    public List<GameObject> boxNoteList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckTiming()
    {

        for (int i = 0; i < boxNoteList.Count; i++)
        {
            Destroy(boxNoteList[i]);
            boxNoteList.RemoveAt(i);
        }
    }
}
