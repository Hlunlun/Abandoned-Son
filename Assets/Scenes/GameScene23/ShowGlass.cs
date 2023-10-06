using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGlass : MonoBehaviour
{
    public GameObject glass01;
    public GameObject glass02;
    public GameObject glass03;
    public GameObject bannedbook;
    public Item Lamp;
    public GameObject coins;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Hole.hole01 == true)
        {
            glass01.SetActive(true);
        }
        if (Hole.hole02 == true)
        {
            glass02.SetActive(true);
        }
        if (Hole.hole03 == true)
        {
            glass03.SetActive(true);
        }
        if(Hole.cabinetOK == 3)
        {
            bannedbook.SetActive(true);
        }
        if (!Lamp.itemCheck)
        {
            //Debug.Log("55555");
            coins.SetActive(true);
            Lamp.itemCheck = true;
        }
    }
}
