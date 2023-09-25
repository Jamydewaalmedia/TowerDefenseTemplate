using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 400; // Maximum health points
   
    [SerializeField]  int currentHealth; // Current health points
    public GameObject findenemy;
    bool movement;
    public GameObject BulletPrefab;
    private Money money;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // Initialize current health
        movement = true;
        money = FindAnyObjectByType<Money>();
    }

    // Update is called once per frame
    void Update()
    {
        if (findenemy == null)
        {

            findenemy = GameObject.FindGameObjectWithTag("Enemy");


        }

        else
        {
            if (movement == true)
            {

                transform.position = Vector2.MoveTowards(transform.position, findenemy.transform.position, 0.5f * Time.deltaTime);


            }
        }

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
        if (GameObject.FindGameObjectWithTag("Enemy"))
        {
            money.AddMoney(150);
        }
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
       

        //movemnt = false;
        if (col.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(25);


            movement = true;
        }
        if (col.gameObject.CompareTag("Attack"))
        {
           TakeDamage(25);


        }
        
       

    }
}
