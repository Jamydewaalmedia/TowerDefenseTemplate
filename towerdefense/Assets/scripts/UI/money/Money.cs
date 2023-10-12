using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{


    public TextMeshProUGUI text;
    public int moneyCount;
    
    // Start is called before the first frame update
    void Start()
    {
       
        text.text = "money : " + moneyCount;
    }
  
    public void AddMoney(int money)
    {
        moneyCount = moneyCount + money;

        text.text = "money : " + moneyCount;
    }
}
