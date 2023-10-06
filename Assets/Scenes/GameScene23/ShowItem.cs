using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowItem : MonoBehaviour
{
    public Item Lamp;
    public GameObject coins;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!Lamp.itemCheck)
        {
            coins.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
