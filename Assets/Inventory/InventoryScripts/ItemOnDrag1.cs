using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemOnDrag1 : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform originalParent;
    public Slot slot;
    public Inventory playerInventory;
    public LayerMask layer;
    private bool scene3 = false;
    public Canvas ClueCanvas;
    private Canvas ClueCanvas01;

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;//原本的位置
        transform.SetParent(transform.parent.parent);//拖曳時不會被擋住
        transform.position = eventData.position;//物品位置即鼠標位置
        //GetComponent<CanvasGroup>().blocksRaycasts = false;//使鼠標能獲取物品後圖層物品的訊息
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;//物品位置即鼠標位置
        //Debug.Log(eventData.pointerCurrentRaycast.gameObject.name);// 顯示鼠標物品後圖層物品的名字
        try
        {
            
            if (slot.slotItem.name == "Highlighter" && SceneManager.GetActiveScene().buildIndex == 2)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, layer);
              
                try
                {
                    if (hit.transform.CompareTag("ComputerNoteBook"))
                    {

                        ItemManager.ComputerNoteBook = true;
                    }
                    else
                    {
                        ItemManager.ComputerNoteBook = false;
                    }
                }
                catch {
                    ItemManager.ComputerNoteBook = false;
                }
                
            }
            if (slot.slotItem.name == "broom" && SceneManager.GetActiveScene().buildIndex == 2)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, layer);
                
                try
                {
                    if (hit.transform.CompareTag("garbage.jpg"))
                    {
                        Destroy(hit.transform.gameObject);
                        Debug.Log("ggggaaa");
                        FindKey.found = true;
                        
                    }
                    else
                    {
                        FindKey.found = false;
                    }
                }
                catch
                {
                   
                }

            }
            if (slot.slotItem.name == "key.jpg" && SceneManager.GetActiveScene().buildIndex == 2)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, layer);                
                try
                {
                    if (hit.transform.CompareTag("cabinet"))
                    {

                        FindSchedual.found = true;
                    }
                    else
                    {
                        FindSchedual.found = true;
                    }
                }
                catch
                {
                    
                }

            }

        }
        catch { }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        bool rightplace = false;
        //if(eventData.pointerCurrentRaycast.gameObject.name == "ItemImage")
        //{
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, layer);
            
            try
            {
                
                if (slot.slotItem.name== "Axe")
                {
                    
                    if (hit.transform.CompareTag("Finish"))
                    {
                        //Debug.Log("TTTT");
                        playerInventory.itemList.Remove(slot.slotItem);
                        Destroy(hit.transform.gameObject);
                        InventoryManager.RefreshItem();
                        rightplace = true;
                        return;
                    }
                }
                if (slot.slotItem.name == "LightTube")
                {
                    if (hit.transform.CompareTag("Lamp"))
                    {
                        //deskBright = true;
                        playerInventory.itemList.Remove(slot.slotItem);
                        InventoryManager.RefreshItem();
                        rightplace = true;
                        return;
                    }
                }
                if (slot.slotItem.name == "medicine")
                {
                    if (hit.transform.CompareTag("Medicine"))
                    {
                        //deskBright = true;
                        ItemOnWorld.medicineAte = true;
                        playerInventory.itemList.Remove(slot.slotItem);
                        InventoryManager.RefreshItem();
                        rightplace = true;
                        return;
                    }
                }
                if (slot.slotItem.name == "mug")
                {
                    if (!visibility.watered)
                    {
                        if (hit.transform.CompareTag("Water"))
                        {
                            //deskBright = true;
                            //playerInventory.itemList.Remove(slot.slotItem);
                            visibility.watered = true;
                            InventoryManager.RefreshItem();
                            rightplace = true;
                            return;
                        }
                    }
                    else
                    {
                        visibility.drug = true;
                        ShowMessage.takeDrug = true;
                        rightplace = true;
                        return;
                    }
                }
                if (slot.slotItem.name == "necklace")
                {
                    if (hit.transform.CompareTag("Memory"))
                    {
                        //deskBright = true;
                        playerInventory.itemList.Remove(slot.slotItem);
                        InventoryManager.RefreshItem();
                        rightplace = true;
                        //*****go to next dialogue*****//
                        SceneManager.LoadScene(8);
                        return;
                    }
                }
                if (slot.slotItem.name == "Coins")
                {
                    if (hit.transform.CompareTag("VendingMachine"))
                    {
                        hit.transform.name = "VendingMachineGet";
                        playerInventory.itemList.Remove(slot.slotItem);
                        InventoryManager.RefreshItem();
                        rightplace = true;
                        return;
                    }
                }
                if (slot.slotItem.name == "Glass3")
                {
                    if (hit.transform.CompareTag("Hole01"))
                    {
                        Hole.cabinetOK++;
                        Hole.hole01 = true;
                        playerInventory.itemList.Remove(slot.slotItem);
                        InventoryManager.RefreshItem();
                        rightplace = true;
                        return;
                    }
                }
                if (slot.slotItem.name == "Glass2")
                {
                    if (hit.transform.CompareTag("Hole02"))
                    {
                        Hole.cabinetOK++;
                        Hole.hole02 = true;
                        playerInventory.itemList.Remove(slot.slotItem);
                        InventoryManager.RefreshItem();
                        rightplace = true;
                        return;
                    }
                }
                if (slot.slotItem.name == "Glass1")
                {
                    if (hit.transform.CompareTag("Hole03"))
                    {
                        Hole.cabinetOK++;
                        Hole.hole03 = true;
                        playerInventory.itemList.Remove(slot.slotItem);
                        InventoryManager.RefreshItem();
                        rightplace = true;
                        return;
                    }
                }
                if (slot.slotItem.name == "Key")
                {
                
                    if (hit.transform.CompareTag("bag"))
                    {

                        WalletManager.Wallet = true;
                        playerInventory.itemList.Remove(slot.slotItem);
                        InventoryManager.RefreshItem();
                        rightplace = true;
                        return;
                    }
                }
                if (slot.slotItem.name == "Wallet")
                {
                
                    if (hit.transform.CompareTag("DoorNext12"))
                    {

                        WalletManager.doorNext12 = true;
                        playerInventory.itemList.Remove(slot.slotItem);
                        InventoryManager.RefreshItem();
                        rightplace = true;
                        return;
                    }
                }

            }
            catch { }
                
        }
        
        //
        
        if (!rightplace)
        {
            Debug.Log("TTTT");
            transform.SetParent(originalParent);
            transform.position = originalParent.position;
            //GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
    }


}
