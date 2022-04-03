using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    Animator animator;
    public ParticleSystem starexplosion;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            print("Player has entered the star");
            animator.SetTrigger("StarActive");
        }
         
     }

    void SpawnParticle () {
        starexplosion.Play();
        ParticleSystem.EmissionModule em = starexplosion.emission;
        em.enabled = true;
        GameObject.Destroy(this.gameObject,0.6f);
    }
}
