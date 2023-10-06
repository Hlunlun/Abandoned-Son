using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMessage : MonoBehaviour
{
    public static bool takeDrug = false ;

    public Canvas tutorialCanvas;

    public LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (takeDrug)
        {
            tutorialCanvas.GetComponent<Canvas>().enabled = true;
            tutorialCanvas.gameObject.SetActive(true);
            Time.timeScale = 0f;
            takeDrug = false;
        }
    }
}
