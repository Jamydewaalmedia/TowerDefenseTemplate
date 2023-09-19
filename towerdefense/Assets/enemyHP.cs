using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHP : MonoBehaviour
{
    public int enemyHp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Attack"))
        {
            enemyHp = enemyHp - 25;


            if (enemyHp <= 0)
            {

                ;
                GameObject.Destroy(gameObject);


            }



        }

    }
}
