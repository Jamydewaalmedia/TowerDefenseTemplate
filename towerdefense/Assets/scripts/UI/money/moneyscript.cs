using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class moneyscript : MonoBehaviour
{


    public TextMeshProUGUI text;
    public int moneyCount;
    
    // Start is called before the first frame update
    void Start()
    {
        text = TextMeshProUGUI.FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void moneyfunction(int money)
    {
        moneyCount = moneyCount + money;

        text.text = "money : " + moneyCount;
    }
}
