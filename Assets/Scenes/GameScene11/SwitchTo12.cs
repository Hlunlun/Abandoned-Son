using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SwitchTo12 : MonoBehaviour
{



    public GameObject character;
    public GameObject nowCamera, nextCamera;
    public LayerMask layer;
    public Canvas plot00;
    public static int Plot = 0;
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
                    character.transform.position = new Vector2(-36, 3);
                    //load a new scen
                    nowCamera.SetActive(false);
                    nextCamera.SetActive(true);
                    if (Plot == 0)
                    {
                        plot00.GetComponent<Canvas>().enabled = true;
                        plot00.gameObject.SetActive(true);
                        Plot++;
                    }
           
                }

            }

            else { }

        }


    }
}
