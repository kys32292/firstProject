using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCreate : MonoBehaviour
{

    public int bpm = 0;
    double currentTime = 0d;

    [SerializeField] Transform tfNoteAppear = null;
    [SerializeField] GameObject goNote = null;

    //public List<GameObject> boxNoteList = new List<GameObject>();

    //NoteL noteL;
    Timing timing;
    NoteL noteL;
    LTiming lTiming;

    // Start is called before the first frame update
    void Start()
    {
        timing = GetComponent<Timing>();
        noteL = GetComponent<NoteL>();
        lTiming = GetComponent<LTiming>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= 60d / bpm)
        {
            GameObject t_note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
            t_note.transform.SetParent(this.transform);
            //lTiming.boxNoteList.Add(t_note);
            //noteL.boxNoteList.Add(t_note);
            //boxNoteList.Add(t_note);
            //timing.boxNoteList.Add(t_note);
            currentTime -= 60d / bpm;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            //lTiming.boxNoteList.Remove(collision.gameObject);
            //noteL.boxNoteList.Remove(collision.gameObject); 
            //boxNoteList.Remove(collision.gameObject);
            //timing.boxNoteList.Remove(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }



}
