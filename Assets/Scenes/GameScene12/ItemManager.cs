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
            computerText.text = "1.�ٴڴ���\n2.�Ҥ�\n3.�ɴڤ�\n4.�׵o�ɶ� ";
        }
        else
        {
            computerText.text = "";
        }
    }
}
