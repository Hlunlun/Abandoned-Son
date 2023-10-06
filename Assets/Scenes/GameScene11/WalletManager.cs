using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalletManager : MonoBehaviour
{
    public static bool Wallet = false;
    public GameObject wallet;
    public static bool doorNext12 = false;
    public GameObject DoorNext12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Wallet == true)
        {
      
            wallet.SetActive(true);
            Wallet = false;
        }
        if (doorNext12 == true)
        {

            DoorNext12.GetComponent<SwitchTo12>().enabled = true;
            doorNext12 = false;
        }
    }
}
