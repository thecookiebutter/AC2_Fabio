using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollision : MonoBehaviour
{
    public GameObject explosionEffect;

    private void OnCollisionEnter(Collision collision)
    {
                        Instantiate(explosionEffect, transform.position, Quaternion.identity);
    }

    private void Start(){

    Destroy(this.gameObject, 10f);
    }
}
