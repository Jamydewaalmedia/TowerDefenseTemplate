using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public Vector2 destination;
    public GameObject waypoint;
    // Update wordt één keer per frame opgeroepen
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right);


        destination = waypoint.transform.position;
        transform.position = Vector2.Lerp(transform.position, waypoint.transform.position,  0.5f * Time.deltaTime);
        if (hit.collider.CompareTag("Attack"));
        {
            Debug.Log("bruh");
        }

    }
}