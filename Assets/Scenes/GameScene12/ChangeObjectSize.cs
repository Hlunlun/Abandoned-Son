using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeObjectSize : MonoBehaviour
{


    public Vector3 objectScale;    
    public LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {        
        objectScale = this.transform.localScale;
    }


    // Update is called once per frame
    void Update()
    {
     
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, layer); ;
            if (hit.collider)
            {
                if(hit.transform.name==this.name)
                transform.localScale = new Vector3(objectScale.x * 1.5f, objectScale.y * 1.5f, 0);
            }
                           
            else
                transform.localScale = new Vector3(objectScale.x, objectScale.y, 0);
        }


    }
}
