using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject spawnrefab;
    public string targetTag = "Attack";
   
  
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {

            GameObject bullet = Instantiate(spawnrefab);
            bullet.transform.position = transform.position;



        }
    }
}
