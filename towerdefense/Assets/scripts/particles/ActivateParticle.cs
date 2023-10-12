using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateParticle : MonoBehaviour
{
    public ParticleSystem hitparticle;
    public string[] targetTags;
    public string particlesystem =  "findsystem";
    // Start is called before the first frame update
    void Start()
    {
        
        hitparticle = GameObject.Find(particlesystem).GetComponent<ParticleSystem>();
    }

    
    
   
    void OnTriggerEnter2D(Collider2D col)
    {

        foreach (string tag in targetTags)
        {
            if (col.gameObject.CompareTag(tag))
            {
                hitparticle.transform.position = col.transform.position;
                startparticle();

            }

        }
    }
    public void startparticle()
    {
        hitparticle.Play();
    }

 }
