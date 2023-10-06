using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BookClick : MonoBehaviour
{

    public Canvas tutorialCanvas;

    public LayerMask layer;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, layer); ;
            if (hit.collider)
            {
                if (hit.transform.name == this.name)
                {
                    tutorialCanvas.GetComponent<Canvas>().enabled = true;
                    tutorialCanvas.gameObject.SetActive(true);
                    Time.timeScale = 0f;
                }
                    
            }

            else { }
                
        }


    }
}
