using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class memory_boxClick : MonoBehaviour
{
    public LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
                    SceneManager.LoadScene(8);
                    
                }

            }

            else { }

        }
    }
}
