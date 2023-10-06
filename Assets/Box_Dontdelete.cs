using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Dontdelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    DontDestroyOnLoad(gameObject);
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
