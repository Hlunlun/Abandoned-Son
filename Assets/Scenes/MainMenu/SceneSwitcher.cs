using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour,IPointerClickHandler
{
    public int SceneIndexDestination = 1;

    public void OnPointerClick(PointerEventData e)
    {
        //get the current scene
        Scene scene = SceneManager.GetActiveScene();

        //load a new scen
        SceneManager.LoadScene(SceneIndexDestination);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
