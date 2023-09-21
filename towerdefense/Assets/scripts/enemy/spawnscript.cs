using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class spawnscript : MonoBehaviour
{
    [SerializeField] GameObject enemyprefab;
    private GameObject waypoint;
    private GameObject enemy;

    // Start is called before the first frame update
    
    void Start()
    {
        
        waypoint = GameObject.FindGameObjectWithTag("waypointenemy");
        StartCoroutine(spawnenemy());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnenemy()
    {
        while (true) 
        {
            enemy = Instantiate(enemyprefab);
            enemy.transform.position= waypoint.transform.position;
            
          
            yield return new WaitForSeconds(10.5f);
        }
        
    }
  
   


}
