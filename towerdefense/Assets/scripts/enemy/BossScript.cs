using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public spawnscript spawnscript;
    private GameObject[] enemies;
    public string targetTag = "Enemy";
    private int EnemiesCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBoss());
        spawnscript = GetComponent<spawnscript>();
        enemies = GameObject.FindGameObjectsWithTag(targetTag);

    }

    // Update is called once per frame
    void Update()
    {
        spawnscript.setspawnstate(SpawnState.BOSS);
        
        if (enemies != null)
        {
            foreach (GameObject enemy in enemies)
            {
                EnemiesCount++;

                Destroy(enemy);
            }
        }
    }
    IEnumerator SpawnBoss()
    {
        while (true)
        {
            yield return new WaitForSeconds(100);

            spawnscript.setspawnstate(SpawnState.BOSS);
        }
    }
}
