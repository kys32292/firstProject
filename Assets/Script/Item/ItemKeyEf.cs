using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ItemEft/Consumable/Key")]
public class ItemKeyEf : ItemEffect
{
    public override bool ExecuteRole()
    {
        Debug.Log("���� �����ϴ�.");
        return true;
    }
}
