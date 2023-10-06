using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class FindSchedual : MonoBehaviour
{
    public GameObject notebook01;
    public static bool found = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (found)
        {
            notebook01.SetActive(true);
        }
        else
        {
            notebook01.SetActive(false);
        }
    }
}
