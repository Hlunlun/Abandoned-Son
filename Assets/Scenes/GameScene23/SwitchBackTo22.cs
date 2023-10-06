using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SwitchBackTo22 : MonoBehaviour
{





    public GameObject character;
    public GameObject nowCamera, preCamera;
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

                    character.transform.position = new Vector2(-46, -4);
                    //load a new scen
                    nowCamera.SetActive(false);
                    preCamera.SetActive(true);


                }

            }

            else { }

        }


    }
}
