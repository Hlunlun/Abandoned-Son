using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemManager : MonoBehaviour
{
    public static bool ComputerNoteBook = false;
    public Text computerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ComputerNoteBook == true)
        {
            computerText.text = "1.還款期限\n2.忌日\n3.借款日\n4.案發時間 ";
        }
        else
        {
            computerText.text = "";
        }
    }
}
