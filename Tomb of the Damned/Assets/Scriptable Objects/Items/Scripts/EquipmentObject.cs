using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")]
public class EquipmentObject : ItemObject
{
    public float attBonus;
    public float defBonus;
    public void Awake()
    {
        type = ItemType.equipment;
    }
}