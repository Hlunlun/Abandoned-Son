using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/New Item")]//按右鍵能新創文件夾
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;

    [TextArea]
    public string itemInfo;

    public bool itemCheck = true;
}