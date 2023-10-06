using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item slotItem;
    public Image slotImage;
    //public string slotInfo;

    public GameObject itemInSlot;
    public void ItemOnClicked()
    {
        InventoryManager.UpdateItemInfo(slotItem.itemInfo);
    }

   
        /*  
        public void SetupSlot(Item item)
        {
            if (item == null)
            {
                itemInSlot.SetActive(false);
                return;
            }

            slotImage.sprite = item.itemImage;
            slotInfo = item.itemInfo;
        }
        */
    
}