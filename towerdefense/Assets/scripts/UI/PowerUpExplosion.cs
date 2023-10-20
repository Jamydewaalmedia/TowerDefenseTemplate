using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class PowerUpExplosion : MonoBehaviour
{
    private GameObject[] enemies;
    public string targetTag = "Enemy";
    public string particlesystem = "nukeparticlesystem";
    public ParticleSystem hitparticle;
    public string explosion = "explosion";
    public AudioSource explosionsound;

    // Start is called before the first frame update
    void Start()
    {
     
        
        hitparticle = GameObject.Find(particlesystem).GetComponent<ParticleSystem>();

        explosionsound = GameObject.Find(explosion).GetComponent<AudioSource>();
    }
    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag(targetTag);
    }



    private void OnMouseDown()
    {

        nukebehavour();
       

        
        
    }
    public void nukebehavour()
    {
        if (enemies != null)
        {
            foreach (GameObject enemy in enemies)
            {

                hitparticle.Play();
                Destroy(enemy);
            }

        }
        explosionsound.PlayOneShot(explosionsound.clip);


        Destroy(gameObject);
    }
}
