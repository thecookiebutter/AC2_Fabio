using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFase1 : MonoBehaviour
{
    public Joystick joystick;
    private Rigidbody2D rb;


    public float force = 5;
    public float torque = 2;

    public Vector2 velocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float hor = joystick.Horizontal;
        float ver = joystick.Vertical;
        rb.AddForce(transform.up * ver * force);
        rb.AddTorque(-hor * torque);

        velocity = rb.velocity;
    }
}
