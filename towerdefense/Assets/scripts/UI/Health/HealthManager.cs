using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class HealthManager : MonoBehaviour
{

    public Image healthbar;
    public float HealthAmount = 100f ;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            TakeDamage(20f);
        }
        
    }
    public void TakeDamage(float Damage)
    {
        HealthAmount -= Damage;
        healthbar.fillAmount = HealthAmount / 100f;


    }
}
