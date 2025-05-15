using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserShooter : MonoBehaviour
{
    public GameObject laserPrefab;  
    public float laserSpeed = 20f;
    public Button LaserButton;
    public Transform shootPoint;


    private void Start()
    {
        LaserButton.onClick.AddListener(ShootLaser);
    }

    void ShootLaser()
    {
        

        GameObject laser = Instantiate(laserPrefab, shootPoint.position, transform.rotation);

        
        Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = transform.up * laserSpeed;
        }
    }
}
