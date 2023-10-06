using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scary01Touch : MonoBehaviour
{
    public Canvas tutorialCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.name == "character_collider")
        {
            tutorialCanvas.GetComponent<Canvas>().enabled = true;
            tutorialCanvas.gameObject.SetActive(true);
            Time.timeScale = 0f;
            Destroy(this.gameObject);
        }
    }
}
