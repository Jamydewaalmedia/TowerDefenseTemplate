using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class moneyscript : MonoBehaviour
{


    public TextMeshProUGUI text;
    public int moneyCount;
    public bool canspawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void moneyfunction(int money)
    {
        moneyCount += money;
        if (moneyCount < 100)
        {

            canspawn = false;
        }
        if (canspawn)
        {
            moneyfunction(-100);
            text.text = "money : " + moneyCount;
            
        }
    }
}
