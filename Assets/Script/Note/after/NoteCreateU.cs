using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCreateU : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;

    [SerializeField] Transform tfNoteAppear = null;
    [SerializeField] GameObject goNote = null;

    TimingU timingU;
    NoteLList noteLList;

    // Start is called before the first frame update
    void Start()
    {
        timingU = GetComponent<TimingU>();
        noteLList = GetComponent<NoteLList>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= 60d / bpm)
        {
            GameObject t_note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
            t_note.transform.SetParent(this.transform);
            timingU.boxNoteList.Add(t_note);
            //noteLList.boxNoteList.Add(t_note);
            currentTime -= 60d / bpm;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            timingU.boxNoteList.Remove(collision.gameObject);
            //noteLList.boxNoteList.Remove(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
