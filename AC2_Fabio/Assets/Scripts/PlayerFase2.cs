using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFase2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10;
    public float deadZone = 0.1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 tilt = Input.acceleration;

        tilt.x = Mathf.Abs(tilt.x) < deadZone ? 0 : tilt.x;
        tilt.y = tilt.y < deadZone ? 0 : tilt.y;


        Vector3 direction = new Vector3(tilt.x * speed, 0, tilt.y * speed);
        rb.velocity = direction;
    }
}
