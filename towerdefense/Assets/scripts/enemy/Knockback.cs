using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    private Rigidbody2D rb2;
    public string[] targetTags;
    public float knockbackAmounth = 0.1f;
    public static event Action oncollision2;

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
        foreach(string tag in targetTags)
        {
            if (col.gameObject.CompareTag(tag))
            {
                knockback(knockbackAmounth);
                oncollision2?.Invoke();
            }
        }
      
    }
    void knockback( float thrust)
    {
        rb2.AddForce(Vector2.right * thrust);
    }

}
