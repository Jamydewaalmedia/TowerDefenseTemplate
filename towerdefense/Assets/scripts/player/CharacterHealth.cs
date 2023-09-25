using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 400; // Maximum health points
    [SerializeField]
    public   int currentHealth; // Current health points
    public GameObject findenemy;
    bool movemnt;
    public GameObject bulletprefab;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // Initialize current health
        movemnt = true;
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
            if (movemnt == true)
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
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
       

        //movemnt = false;
        if (col.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(25);


            movemnt = true;
        }
        if (col.gameObject.CompareTag("1hit"))
        {

            GameObject bullet = Instantiate(bulletprefab);
            bullet.transform.position = col.gameObject.transform.position;





            movemnt = true;
            if (col.gameObject.CompareTag("bullet"))
            {
                
                TakeDamage(2000);

            }
        }

    }
}
