using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SwitchTo11 : MonoBehaviour
{
    private int SceneIndexDestination;

    // Start is called before the first frame update
    public SwitchTo11(int SceneIndexDestination)
    {
        Scene scene = SceneManager.GetActiveScene();

        //load a new scen
        SceneManager.LoadScene(SceneIndexDestination);
    }

}
