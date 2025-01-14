using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterHealth characterHealth;
    public string[] targetTags;
    public int damageAmount = 25;

    private void Start()
    {
        characterHealth = GetComponent<CharacterHealth>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        DamageAllTarget(col);
    }
    void DamageAllTarget(Collider2D col)
    {
        foreach (string tag in targetTags)
        {
            if (col.gameObject.CompareTag(tag))
            {
                characterHealth.TakeDamage(damageAmount);
            }

        }
    }
}