using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBox : MonoBehaviour
{
    public Text OutText;
    public Text numberText;
    public Canvas canvas;
    public string number = "24";
    public GameObject book1,key;
    public Text text01;
    // Start is called before the first frame update
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        if (numberText.text== number)
        {
            Time.timeScale = 1f;
            canvas.gameObject.SetActive(false);
            canvas.GetComponent<Canvas>().enabled = false;
            Destroy(book1);

            key.gameObject.SetActive(true);
        }
        else if (numberText.text != number)
        {
            text01.text = "Wrong Answer";
        }
        else if(numberText.text != "")
        {
            text01.text = "";
        }
       
    }
}
