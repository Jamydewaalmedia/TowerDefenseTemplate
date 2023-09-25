using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class troopspawner : MonoBehaviour
{
    public GameObject waypoint;
    [SerializeField] GameObject trooperprefab;
    
    public bool canspawnknight;
    [SerializeField] private moneyscript moneyScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawntroop()
    {

        if (canspawnknight)
        {
            GameObject troopknight = Instantiate(trooperprefab);
            troopknight.transform.position = waypoint.transform.position;
            moneyScript.moneyfunction(-100);
        }
        if (moneyScript.moneyCount < 100)
        {

            canspawnknight = false;
        }
        if (moneyScript.moneyCount >= 100)
        {

            canspawnknight = true;
        }



    }
}
