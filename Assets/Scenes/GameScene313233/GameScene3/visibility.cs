using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visibility : MonoBehaviour
{
    public static bool drug = false;
    public static bool watered = false;
    public GameObject box;
    public LayerMask layer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (drug)
        {
            box.SetActive(true);
            drug = false;
        }
    }
}
