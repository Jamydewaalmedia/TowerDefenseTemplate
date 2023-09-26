using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    
    public GameObject powerUpPrefab; // Sleep hier je power-up prefab naartoe in de Inspector.



    public void ActivatePowerUp()
    { 
        // Instantieer de power-up prefab op een willekeurige positie.
        Vector3 spawnPosition = new Vector2(transform.position.x, 2f);
        Instantiate(powerUpPrefab, spawnPosition, Quaternion.identity);
    }
}
