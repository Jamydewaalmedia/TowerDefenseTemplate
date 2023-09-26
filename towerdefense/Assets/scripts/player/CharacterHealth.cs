using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 400; // Maximum health points
   
    [SerializeField]  int currentHealth; // Current health points
    public GameObject BulletPrefab;
    private Money money;
   


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // Initialize current health
        
        money = FindAnyObjectByType<Money>();
    }

   
   
      

    // Method to apply damage to the character
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;

        if (currentHealth <= 0)
        {
            HandleDeath(); // Handle character death
        }
    }

    // Customize this method for specific behavior upon character death
    private void HandleDeath()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            money.AddMoney(150);
            
        }

        Destroy(gameObject);
    }
  
}
