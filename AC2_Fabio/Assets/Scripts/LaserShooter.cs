using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooter : MonoBehaviour
{
    public GameObject laserPrefab;  // The laser prefab to instantiate
    public float laserSpeed = 20f;  // Speed of the laser
    public Transform shootPoint;    // Where the laser will spawn from (e.g., in front of the player)

    void Update()
    {
        // Detect input (space bar) to shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootLaser();
        }
    }

    void ShootLaser()
    {
        // Instantiate the laser at the shoot point with no rotation
        GameObject laser = Instantiate(laserPrefab, shootPoint.position, Quaternion.identity);

        // Get the Rigidbody component to apply movement
        Rigidbody rb = laser.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Move the laser forward with the specified speed
            rb.velocity = transform.forward * laserSpeed;
        }
    }
}
