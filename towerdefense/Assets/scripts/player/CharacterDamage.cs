using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterHealth characterHealth;
    public string targetTag = "Enemy";
    public int damageAmount = 25;

    private void Start()
    {
        characterHealth = GetComponent<CharacterHealth>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {


        //movemnt = false;
        if (col.gameObject.CompareTag(targetTag))
        {
            characterHealth.TakeDamage(damageAmount);

        }
       
    }
}