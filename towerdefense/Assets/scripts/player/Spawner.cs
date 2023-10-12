using System.Collections;
using UnityEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab; // The prefab to spawn
    public Transform spawnPoint; // The point where the prefab will spawn
    public int spawnCost = 100; // The cost to spawn the prefab
    public Money Money; // Reference to your money script
    public bool cooldown = true;

    private bool canSpawn; // A flag to check if spawning is allowed

    private void Start()
    {

        cooldown = true;
        canSpawn = Money.moneyCount >= spawnCost;

    }

    private void Update()
    {
        // Check if the player has enough money to spawn
        if (Money.moneyCount < spawnCost)
        {
            canSpawn = false;
        }
        else
        {
            canSpawn = true;
        }

 
    }

  
    public void SpawnObject()
    {
        if (canSpawn)
        {  
            if(cooldown)
            {
                Money.AddMoney(-spawnCost);

                // Spawn the prefab at the specified position
                Instantiate(spawnPrefab, spawnPoint.position, Quaternion.identity);
                cooldown = false;
                Invoke(nameof(cooldownshit), 3f);
            }


        }
     
    }
    public void cooldownshit()
    {

        cooldown = true;



    }


}
