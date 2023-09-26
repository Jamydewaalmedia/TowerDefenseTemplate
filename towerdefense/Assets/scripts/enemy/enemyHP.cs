using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHP : MonoBehaviour
{
    public int enemyHp;


    private Money money;


    private void Start()
    {
        money = FindAnyObjectByType<Money>();
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Attack"))
        {
            enemyHp = enemyHp - 25;


            if (enemyHp <= 0)
            {
                money.AddMoney(150);

                GameObject.Destroy(gameObject);


            }



        }
       

    }
}
