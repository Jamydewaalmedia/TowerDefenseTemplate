using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseDamage : MonoBehaviour
{
    
    public HealthManager healthManager;
    public string targetTag = "Enemy";
    public bool testcooldown;
    // Start is called before the first frame update
    void Start()
    {
        
        healthManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();
    }

    // Update is called once per frame
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        comparetarget(collision);
       
    }
    public void comparetarget(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {

            healthManager.TakeDamage(25f);

        }
    }
}
