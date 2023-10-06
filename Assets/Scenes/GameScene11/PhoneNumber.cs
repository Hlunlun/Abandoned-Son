using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PhoneNumber : MonoBehaviour
{
   // public Text OutText;
    public Text numberText;
    public Canvas canvas;
    public string number = "1745";
    public GameObject phone01, phone02;
    public Text text01;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      
            if (numberText.text == number)
            {
                
                
                Time.timeScale = 1f;
                canvas.gameObject.SetActive(false);
                canvas.GetComponent<Canvas>().enabled = false;
                Destroy(phone01);

                phone02.gameObject.SetActive(true);
                SceneManager.LoadScene(3);
            }
            else if (numberText.text != number)
            {

                text01.text = "Wrong Answer";



            }
            else if (numberText.text != "")
            {
                text01.text = "";
            }
     
        

    }
}
