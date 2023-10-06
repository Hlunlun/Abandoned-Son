using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindKey : MonoBehaviour
{
    public GameObject key01;
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
            key01.SetActive(true);
            found = false;
        }
        
    }
}
