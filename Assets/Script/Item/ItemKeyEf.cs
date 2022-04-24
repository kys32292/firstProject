using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ItemEft/Consumable/Key")]
public class ItemKeyEf : ItemEffect
{
    public override bool ExecuteRole()
    {
        Debug.Log("문이 열립니다.");
        return true;
    }
}
