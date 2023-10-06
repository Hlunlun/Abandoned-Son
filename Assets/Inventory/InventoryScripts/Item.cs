using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/New Item")]//���k���s�Ф��
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;

    [TextArea]
    public string itemInfo;

    public bool itemCheck = true;
}