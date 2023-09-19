using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyknockback : MonoBehaviour
{
    private Rigidbody2D rb2;
     
    // Start is called before the first frame update
    void Start()
    {
        rb2= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Attack"))
        {
            knockback(0.2f);

        }

    }
    void knockback(float thrust)
    {
        rb2.AddForce(Vector2.right * thrust);
    }
}
