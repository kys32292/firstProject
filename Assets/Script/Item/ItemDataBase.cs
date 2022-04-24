using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    public static ItemDataBase instacne;

    public void Awake()
    {
        instacne = this;
    }

    public List<Item> itemList = new List<Item>();
    [Space(20)]

    public GameObject fieldItemPrefab;
    public Vector3[] pos;

    // Start is called before the first frame update
    void Start()
    {
        //itemList.Add(new Item(001, "Key", "문을 열수 있는 열쇠", Item.ItemType.Use));

        for (int i =0; i < 3; i++)
        {
            GameObject go = Instantiate(fieldItemPrefab, pos[i], Quaternion.identity);
            go.GetComponent<FieldItems>().SetItem(itemList[Random.Range(0, 3)]);
            go.transform.SetParent(this.transform);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
