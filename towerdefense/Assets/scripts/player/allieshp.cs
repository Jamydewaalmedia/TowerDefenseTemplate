using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allieshp : MonoBehaviour
{
    public GameObject findenemy;
    public int knightHp = 75;
    public bool movemnt;
    public GameObject bulletprefab;
    public GameObject findknight;
    
    private void Start()
    {
        findenemy = GameObject.FindGameObjectWithTag("Enemy");
       
        findknight = GameObject.FindGameObjectWithTag("Attack");
        
    }

    private void Update()
    {
        if (findenemy == null)
        {

            findenemy = GameObject.FindGameObjectWithTag("Enemy");
         

        }
    
        else
        {
            if (movemnt == true)
            {

                transform.position = Vector2.MoveTowards(transform.position, findenemy.transform.position, 0.5f * Time.deltaTime);


            }
        }

        if (knightHp <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnCollisionEnter2D");

        //movemnt = false;
        if (col.gameObject.CompareTag("Enemy") )
        {
            knightHp = knightHp - 25;

            
            movemnt = true;
        }
        if (col.gameObject.CompareTag("1hit"))
        {

            GameObject bullet = Instantiate(bulletprefab);
            bullet.transform.position = col.gameObject.transform.position;

            
            


            movemnt = true;
            if (knightHp <= 0)
            {
                GameObject.Destroy(gameObject);


            }
        }

    }
}