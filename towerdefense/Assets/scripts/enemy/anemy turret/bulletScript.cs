using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject findknight;
    private CharacterHealth characterHealth;
    // Start is called before the first frame update
    void Start()
    {
        findknight = GameObject.FindGameObjectWithTag("Attack");
        characterHealth = findknight.GetComponent<CharacterHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (findknight == null)
        {
            findknight = GameObject.FindGameObjectWithTag("Attack");
            characterHealth = findknight.GetComponent<CharacterHealth>();
            if (findknight == null )
            {
                findknight = GameObject.FindGameObjectWithTag("Riot");

                if (findknight == null)
                {
                    Destroy(gameObject);
                }
            }
            
        }

        else
        { bullet.transform.position = Vector2.MoveTowards(transform.position, findknight.transform.position, 0.5f * Time.deltaTime); }
      
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Attack"))
        {

            characterHealth.TakeDamage(2000);
            
            GameObject.Destroy(gameObject);
            

        }
    }

}
