using UnityEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab; // The prefab to spawn
    public Transform spawnPoint; // The point where the prefab will spawn
    public int spawnCost = 100; // The cost to spawn the prefab
    public moneyscript moneyScript; // Reference to your money script

    private bool canSpawn; // A flag to check if spawning is allowed

    private void Start()
    {
        
        canSpawn = moneyScript.moneyCount >= spawnCost;
    }

    private void Update()
    {
        // Check if the player has enough money to spawn
        if (moneyScript.moneyCount < spawnCost)
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
            moneyScript.moneyfunction(-spawnCost);

            // Spawn the prefab at the specified position
            Instantiate(spawnPrefab, spawnPoint.position, Quaternion.identity);
        }
     
    }
}
