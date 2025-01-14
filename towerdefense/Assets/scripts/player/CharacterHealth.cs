using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 400; // Maximum health points
   
    [SerializeField]  int currentHealth; // Current health points
    public GameObject BulletPrefab;
    private Money money;
    private PowerUpManager powerUpManager;
    [SerializeField]float activationChance = 0.25f; // Stel hier de gewenste kans in tussen 0 en 1 (bijvoorbeeld 0.25 voor 25% kans).
    public string targetTag = "Enemy";


    void Start()
    {
        
        currentHealth = maxHealth; // Initialize current health
        
        money = FindAnyObjectByType<Money>();
        powerUpManager = FindAnyObjectByType<PowerUpManager>();
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
        if (gameObject.CompareTag(targetTag))
        {
            money.AddMoney(75);

            float randomValue = Random.Range(0f, 1f);
            
            if (randomValue < activationChance)
            {
                powerUpManager.ActivatePowerUp();
            }
        }

        Destroy(gameObject);
    }
  
}
