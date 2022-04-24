using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LTiming : MonoBehaviour
{
    public List<GameObject> boxNoteList = new List<GameObject>();

    [SerializeField] Transform Center = null;
    [SerializeField] RectTransform[] timingRect = null;
    int count = 0;

    Vector2[] timingBoxs = null;

    // Start is called before the first frame update
    void Start()
    {
        // 타이밍 박스 설정  
        timingBoxs = new Vector2[timingRect.Length];
        for (int i = 0; i < timingRect.Length; i++)
        {
            timingBoxs[i].Set(Center.localPosition.x - timingRect[i].rect.width / 2, Center.localPosition.x + timingRect[i].rect.width / 2);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckTiming()
    {
        for (int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosX = boxNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    Destroy(boxNoteList[i]);
                    boxNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);
                    count++;
                    if (count == 10)
                    {
                        //SceneManager.LoadScene("Sloth");
                        SceneManager.UnloadSceneAsync("New Scene");
                    }
                    return;
                }
            }
        }

        Debug.Log("Miss");
    }
}
