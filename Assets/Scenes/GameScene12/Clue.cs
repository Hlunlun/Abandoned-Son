using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Clue : MonoBehaviour
{
    
    private bool isMouseDown;
    private Vector3 lastMousePosition = Vector3.zero;
    public LayerMask layer;   
    public Text cluetext;
    private Text clue;
    private int index00;
    public Slot slot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void TwoDMove()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, layer);
        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider)
                if (hit.transform.name == this.name)
                    isMouseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {   
            if (hit.collider)
                if (hit.transform.name == this.name)
                {
                    isMouseDown = false;
                    lastMousePosition = Vector3.zero;//這裡要歸零，不然會有漂移效果
                }                    
        }
        if (isMouseDown)
        {
           
            if (lastMousePosition != Vector3.zero)
            {
                Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastMousePosition;
                transform.position += offset;
                
            }
            lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
        }

        if (hit.collider)
            if (hit.transform.name == "ComputerNoteBook") clue.text = "here!!";
        else clue.text = "";

    } 
    
    // Update is called once per frame
    void Update()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("RRRRRRRRRRRRR"+index);
        index00 = index;
        if (index == 3)
        {

            clue = Instantiate(cluetext, new Vector2(0, 0), Quaternion.Euler(0, 0, 0));

        }
   
        TwoDMove();
        
        
    }   
}

//https://www.itread01.com/content/1548516249.html
