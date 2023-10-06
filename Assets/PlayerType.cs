using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerType : MonoBehaviour
{
    public GameObject type1;
    public GameObject type2;
    public bool toggle=true;
   


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)){
            if (toggle==true)
            {
                type1.SetActive(false);
                type2.SetActive(true);
                toggle = false;
            }
            else
            {
                type1.SetActive(true);
                type2.SetActive(false);
                toggle = true;
            }
        }
    }
}
