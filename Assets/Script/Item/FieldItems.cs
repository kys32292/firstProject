using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldItems : MonoBehaviour
{

    public Item item;
    public SpriteRenderer image;

    public void SetItem(Item _item)
    {
        item.itemName = _item.itemName;
        item.itemType = _item.itemType;
        item.itemImage = _item.itemImage;
        item.efts = _item.efts;

        image.sprite = item.itemImage;
    }

    public Item GetItem()
    {
        return item;
    }

    public void DestoryItem()
    {
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
