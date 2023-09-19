using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public int enemyHp = 50;
    public bool movemnt;
    public Vector2 destination;
    public GameObject waypoint;
    public bool alive = true;
    public GameObject enemy;


    // Update wordt één keer per frame opgeroepen


    private void Start()
    {
        
        enemy = GameObject.FindGameObjectWithTag("Enemy");

        waypoint = GameObject.FindGameObjectWithTag("Waypoint");


    }
    void Update()
    {

        if (movemnt == true)
        {

            transform.position = Vector2.MoveTowards(transform.position, waypoint.transform.position, 1f * Time.deltaTime);
        }




    }
 
}