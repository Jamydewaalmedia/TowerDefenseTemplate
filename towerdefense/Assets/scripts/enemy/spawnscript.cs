using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.UI;
using UnityEngine.UI;
using UnityEngine.UIElements;

public enum SpawnState
{
    ENDLESS,
    BOSS
}

public class spawnscript : MonoBehaviour
{
    SpawnState spawnState;
    [SerializeField] GameObject enemyprefab;
    private GameObject waypoint;
    private GameObject enemy;
    [SerializeField] float initialDelay = 1.0f; 
    public DelayModifier delayModifier;

    
    void Start()
    {
        spawnState = SpawnState.ENDLESS;
        waypoint = GameObject.FindGameObjectWithTag("waypointenemy");
        delayModifier.delay = initialDelay; 
        StartCoroutine(SpawnEnemy());
        StartCoroutine(Harder());
    }




    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            if (spawnState == SpawnState.ENDLESS) { 
                enemy = Instantiate(enemyprefab);
                enemy.transform.position = waypoint.transform.position;
            }
            yield return new WaitForSeconds(delayModifier.delay);
        }
    }
    IEnumerator Harder()
    {
        while (true)
        { 

            yield return new WaitForSeconds(10); // Wait for 10 seconds before modifying the delay
            if (spawnState == SpawnState.ENDLESS)
            {
                delayModifier.ModifyDelayByPercentage(5); // Reduce the delay by 5%
            }
            
        }
    }
    public void setspawnstate(SpawnState newSpawnState)
    {
        spawnState = newSpawnState;
    }
  

    



}
