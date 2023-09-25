using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.UI;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class spawnscript : MonoBehaviour
{
    [SerializeField] GameObject enemyprefab;
    private GameObject waypoint;
    private GameObject enemy;
    [SerializeField] float initialDelay = 1.0f; // The initial delay between spawns
    
    public DelayModifier delayModifier;

    // Start is called before the first frame update
    void Start()
    {
        waypoint = GameObject.FindGameObjectWithTag("waypointenemy");
        delayModifier.delay = initialDelay; // Set the initial delay

        StartCoroutine(SpawnEnemy());
        
        StartCoroutine(Harder());
    }


    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            enemy = Instantiate(enemyprefab);
            enemy.transform.position = waypoint.transform.position;

            yield return new WaitForSeconds(delayModifier.delay);
        }
    }
    IEnumerator Harder()
    {
        while (true)
        {
            yield return new WaitForSeconds(10); // Wait for 10 seconds before modifying the delay
            delayModifier.ModifyDelayByPercentage(5); // Reduce the delay by 5%
        }
    }





}
