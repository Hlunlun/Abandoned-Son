using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendMessage : MonoBehaviour
{
    public Text OutText;
    public Text InText;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        
        btn.onClick.AddListener(delegate
        {
            BtnClick();
            InText.text = "";            
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void BtnClick()
    {
        if(InText.text!="")
        {
            OutText.text = OutText.text + "\n" + InText.text;
           
        }
        
        
    }


}
