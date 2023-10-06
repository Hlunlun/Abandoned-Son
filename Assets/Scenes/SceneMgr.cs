using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMgr : MonoBehaviour
{
    // Start is called before the first frame update
    public static SceneMgr sceneMgr;
    private void Awake()
    {
        if(sceneMgr == null)
        {
            sceneMgr = this;
            DontDestroyOnLoad(this);
        }else if(sceneMgr != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }
    Dictionary<string, object> sceneOneshotData = null;
    private void WriteSceneData(Dictionary<string,object> data)
    {
        if(sceneOneshotData != null)
        {
            Debug.LogError("切換數據不為空，上一次切換場景的數據沒有被讀取");
        }

    }
    public Dictionary<string, object> ReadSceneData()
    {
        Dictionary<string, object> tempData = sceneOneshotData;
        sceneOneshotData = null;
        return tempData;
    }
    // Update is called once per frame
    public void ToNewScene(string sceneName, Dictionary<string, object>param = null)
    {
        this.WriteSceneData(param);
        SceneManager.LoadScene(sceneName);
    }
    void Update()
    {
        
    }
}
