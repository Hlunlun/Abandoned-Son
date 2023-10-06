using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{

    static InventoryManager instance;
    
    

    public Inventory myBag;
    public GameObject slotGrid;
    //public GameObject emptySlot;
    public Slot slotPrefab;
    public Text itemInformation;

    //public List<GameObject> slots = new List<GameObject>();
 
    void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }

    void OnEnable()
    {
        RefreshItem();
        instance.itemInformation.text = "";
    }

    public static void UpdateItemInfo(string itemDescription)
    {
        instance.itemInformation.text = itemDescription;
    }

    public static void CreateNewItem(Item item)
    {
        Slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
    }
    

    public static void RefreshItem() //多重物品時顯示在物品欄
    {
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if (instance.slotGrid.transform.childCount == 0)
            {
                break;
            }
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
            //instance.slots.Clear();
        }

        for (int i = 0; i < instance.myBag.itemList.Count; i++)
        {
            CreateNewItem(instance.myBag.itemList[i]);
            //instance.slots.Add(Instantiate(instance.emptySlot));
            //instance.slots[i].transform.SetParent(instance.slotGrid.transform);
            //instance.slots[i].GetComponent<Slot>().SetupSlot(instance.myBag.itemList[i]);
        }
    }
    
    
}