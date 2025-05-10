using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float ThresholdShake = 2;
    public float lastTimeShake;
    public GameObject explosionEffect;
    public bool shakeAvailable = true;

    private void Update()
    {
        if (Input.acceleration.magnitude >= ThresholdShake)
        {
            if (Time.time - lastTimeShake > 0.5f) { 
                lastTimeShake = Time.time;

                if (transform.localScale.x == 2) {
                    transform.localScale = new Vector3(1, 1, 1);
                }
                else
                {
                    transform.localScale = new Vector3(2, 2, 2);
                }
                DestroyAllMeteors();
                shakeAvailable = false;
            }
        }
    }

    void DestroyAllMeteors()
{
    GameObject[] meteors = GameObject.FindGameObjectsWithTag("Meteoro");

    foreach (GameObject meteor in meteors)
    {
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, meteor.transform.position, Quaternion.identity);
        }

        Destroy(meteor);
    }
}
}
