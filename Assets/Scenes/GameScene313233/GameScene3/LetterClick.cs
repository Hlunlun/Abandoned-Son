using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LetterClick : MonoBehaviour
{
    public Canvas tutorialCanvas;
    public static bool locked = true;
    public GameObject mailbox;

    //answer box
    public Text OutText;
    public Text numberText;
    public Canvas canvas;
    //public GameObject book1;
    public Text text01;

    public LayerMask layer;
    // Start is called before the first frame update   
    

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            if (!locked)
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
            else
            {
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, layer); ;
                if (hit.collider)
                {
                    if (hit.transform.name == this.name)
                    {
                        canvas.GetComponent<Canvas>().enabled = true;
                        canvas.gameObject.SetActive(true);
                        Time.timeScale = 0f;
                    }
                }

                else { }
            }
            
        }


    }

}
