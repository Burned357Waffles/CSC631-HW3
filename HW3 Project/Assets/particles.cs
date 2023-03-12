using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour
{
   ParticleSystem ParticleSystem;

   void Start() {
        ParticleSystem = GetComponent<ParticleSystem>();
   }


    void OnCollisionEnter(Collision other) {
       ParticleSystem.Play();
   }

}
