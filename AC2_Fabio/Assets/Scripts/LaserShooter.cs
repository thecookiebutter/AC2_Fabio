using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooter : MonoBehaviour
{
    public GameObject laserPrefab;  
    public float laserSpeed = 20f;  
    public Transform shootPoint;    

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootLaser();
        }
    }

    void ShootLaser()
    {
        

        GameObject laser = Instantiate(laserPrefab, shootPoint.position, Quaternion.identity);

        
        Rigidbody rb = laser.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * laserSpeed;
        }
    }
}
