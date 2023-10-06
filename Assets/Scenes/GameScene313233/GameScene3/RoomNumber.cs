using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomNumber : MonoBehaviour
{
    public Text OutText;
    public Text numberText;
    public Canvas canvas;
    public string number = "726";
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
            LetterClick.locked = false;
            Time.timeScale = 1f;
            canvas.gameObject.SetActive(false);
            canvas.GetComponent<Canvas>().enabled = false;
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
