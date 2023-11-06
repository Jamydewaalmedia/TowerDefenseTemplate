using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{

     GameObject target;
    [SerializeField] float speed = 1;
    public string targetTag = "Waypoint";

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag(targetTag);
    }

    void Update()
    {

        SetTarget();
    }
    public void SetTarget()
    {
        if (target == null)
        {

            target = GameObject.FindGameObjectWithTag(targetTag);


        }

        else
        {


            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);



        }
    }
}
