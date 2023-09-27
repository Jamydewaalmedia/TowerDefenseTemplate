using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpExplosion : MonoBehaviour
{
    private GameObject[] enemies;
    public string targetTag = "Enemy";

    // Start is called before the first frame update
    void Start()
    {
        // Assign the result of FindGameObjectsWithTag to the class-level enemies array.
        enemies = GameObject.FindGameObjectsWithTag(targetTag);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        // Check if enemies array is not null before attempting to destroy enemies.
        if (enemies != null)
        {
            foreach (GameObject enemy in enemies)
            {
                Destroy(enemy);
            }
        }

        // Destroy the GameObject this script is attached to.
        Destroy(gameObject);
    }
}
