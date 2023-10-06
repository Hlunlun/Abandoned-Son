using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemOnWorld : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInventory;
    public LayerMask layer;
    public static bool medicineAte = false;
    private void Start()
    {
        Debug.Log("00"+thisItem.name);
    }
    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, layer); ;
            if (hit.collider && hit.transform.name =="Key" && hit.transform.name ==this.name)
            {
                
                //Debug.DrawLine(ray.origin, hit.transform.position, Color.red, 0.1f, true);
                //Debug.Log(hit.transform.name);
                //if (hit.transform.CompareTag("Player"))
                //Debug.Log(hit.transform.tag);

                AddNewItem();

                Destroy(hit.transform.gameObject);
            }else if(hit.collider && hit.transform.name == "Highlighter" && hit.transform.name == this.name)
            {
                AddNewItem();

                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "Axe" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "LightTube" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "Cabinet" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "medicine" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "mug" && hit.transform.name == this.name && medicineAte)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "necklace" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "BannedBook" && hit.transform.name == this.name)
            {
                Hole.cabinetOK = 100;
                AddNewItem();
                SceneManager.LoadScene(5);
                
                //Destroy(hit.transform.gameObject);
                //hit.transform.name = "CabinetOpen";
            }
            else if (hit.collider && hit.transform.name == "Coins" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "Glass3" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "Bed" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "VendingMachineGet" && hit.transform.name == this.name)
            {
                AddNewItem();
                //Destroy(hit.transform.gameObject);
                hit.transform.name = "VendingMachineGetEnd";
            }
            else if (hit.collider && hit.transform.name == "broom" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "rag" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "key.jpg" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider && hit.transform.name == "Wallet" && hit.transform.name == this.name)
            {
                AddNewItem();
                Destroy(hit.transform.gameObject);
            }
            

        }

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, layer); ;
            if (hit.collider && hit.transform.name == "Lamp" && hit.transform.name == this.name)
            {
                thisItem.itemCheck = false;//桌子亮了
            }
        }
    }
    
    
    
    /*private void OnTriggerEnter2D(Collider2D other)//碰撞方式增加物品
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AddNewItem();
            Destroy(gameObject);
        }
    }
    */

    public void AddNewItem()
    {
        Debug.Log("00" + thisItem.name);
        playerInventory.itemList.Add(thisItem);
        //InventoryManager.CreateNewItem(thisItem);
        /*for(int i = 0; i < playerInventory.itemList.Count; i++)
        {
            if(playerInventory.itemList[i] == null)
            {
                playerInventory.itemList[i] = thisItem;
                break;
            }
        }
        */
        InventoryManager.RefreshItem();
    }

}