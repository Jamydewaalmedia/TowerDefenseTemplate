using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class HealthManager : MonoBehaviour
{
    public menu Scenechangers;
    public Image healthbar;
    public float HealthAmount = 100f ;
    private ActivateParticle activateParticle;
    void Start()
    {
       
         Scenechangers = GameObject.Find("Scenechanger").GetComponent<menu>();
         activateParticle = FindAnyObjectByType<ActivateParticle>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            TakeDamage(20f);
        }
        if(healthbar.fillAmount <= 0) 
        {
            Scenechangers.scenechanger("GameOver");
        }
        
    }
    public void TakeDamage(float Damage)
    {
        HealthAmount -= Damage;
        healthbar.fillAmount = HealthAmount / 100f;
       


    }
}
