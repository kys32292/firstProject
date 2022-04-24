using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Item
{

    public enum ItemType // enum = enumeration�� ���ڷ� ���Ŷ�� ��
    {
        Consumables
    }

    //public int itemID;  //�������� ���� ID������ �ߺ��� �Ұ��� �� ���̴�.
    public string itemName; //������ �̸����� �ߺ��� �����ϴ�. ID�� �����
    //public string itemDes; //������ ����
    //public int itemCount; //������ ���� ����
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
