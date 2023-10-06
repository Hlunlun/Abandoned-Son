using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Plot1 : MonoBehaviour
{
    public Text PlotText;
    public Text Speaker;
    private string nameAndPath;//�s�ɸ�|+�ɦW
    public StreamReader _streamReader;
    //LoadData();



    public void LoadData()
    {
        string data = _streamReader.ReadLine();//Ū���@��@��
        try
        {
            if (data.Substring(3, 1).Equals("："))
            {
                Speaker.text = data.Substring(0, 3);
                PlotText.text = data.Substring(4, data.Length - 4) + "\n";
            }
            else if (data.Substring(0, 1).Equals("："))
            {
                Speaker.text = "你";
                PlotText.text = data.Substring(1) + "\n";
            }
            else
            {
                Speaker.text = "";
                PlotText.text = data;
            }
        }
        catch
        {
            //Speaker.text = "";
            //PlotText.text = data;
            SwitchTo11 sw = new SwitchTo11(4);
        }
        //string speaker = data[0];
        //string line = data[1];


        // _streamReader.Close();//�O�o�n�����A���M�|����

    }

    // Start is called before the first frame update
    void Start()
    {

        string filePath = Application.dataPath ;
        //Debug.Log(filePath);
        nameAndPath = filePath + "/" + "chapter1.txt";//�ɪ���m�[�ɦW
        _streamReader = File.OpenText(nameAndPath);
        LoadData();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadData();
        }
    }
}
