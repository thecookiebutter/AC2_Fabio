using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollision : MonoBehaviour
{
    public GameObject explosionEffect;

    private void OnTriggerEnter2D(Collider trigger)
    {
           Instantiate(explosionEffect, transform.position, Quaternion.identity);
           Destroy(this.gameObject);      
    }

    private void Start(){

    Destroy(this.gameObject, 10f);
    
    }
}
