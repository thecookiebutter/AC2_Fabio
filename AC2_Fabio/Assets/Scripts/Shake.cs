using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float ThresholdShake = 2;
    public float lastTimeShake;
    public GameObject explosionEffect;
    public bool shakeAvailable = true;

    private void Start()
    {
        GameManager.Instance.PlayerWin.AddListener(PlayerWin);
    }

    private void Update()
    {
        if (Input.acceleration.magnitude >= ThresholdShake)
        {
            if (shakeAvailable) { 
                lastTimeShake = Time.time;

                DestroyAllMeteors();
                shakeAvailable = false;
            }
        }
    }

    public void PlayerWin()
    {
        DestroyAllMeteors();
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
    private void OnDestroy()
    {
        GameManager.Instance.PlayerWin.AddListener(PlayerWin);
    }
}
