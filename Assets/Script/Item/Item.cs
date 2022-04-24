using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Item
{

    public enum ItemType // enum = enumeration의 약자로 열거라는 뜻
    {
        Consumables
    }

    //public int itemID;  //아이템의 고유 ID값으로 중복은 불가능 할 것이다.
    public string itemName; //아이템 이름으로 중복이 가능하다. ID도 만든거
    //public string itemDes; //아이템 설명
    //public int itemCount; //아이템 소지 갯수
    public Sprite itemImage;
    public ItemType itemType;
    public List<ItemEffect> efts;

    public bool Use()
    {
        bool isUsed = false;
        foreach (ItemEffect eft in efts)
        {
            isUsed = eft.ExecuteRole();
        }
        return isUsed;
    }



    /*public Item(int _itemID, string _itemName, string _itemDes,  ItemType _itemType, int _itemCount = 1)
    {
        itemID = _itemID;
        itemName = _itemName;
        itemType = _itemType;
        itemDes = _itemDes;
        itemCount = _itemCount;
        itemIcon = Resources.Load("ItemIcon/" + _itemID.ToString(), typeof(Sprite)) as Sprite;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
