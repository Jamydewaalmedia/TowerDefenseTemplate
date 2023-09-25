using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{

    [SerializeField] GameObject target;
    [SerializeField] float speed = 1;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Waypoint");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}