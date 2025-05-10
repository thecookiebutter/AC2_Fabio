using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFase1 : MonoBehaviour
{
    public Joystick joystick;
    public float rotationSpeed = 200f;
    public float thrustForce = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Rotação baseada no eixo horizontal
        float rotationInput = joystick.Horizontal;
        float rotationAmount = -rotationInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, rotationAmount);

        // Impulso vertical (como propulsão)
        float verticalInput = joystick.Vertical;
        if (Mathf.Abs(verticalInput) > 0.1f)
        {
            Vector2 force = transform.up * verticalInput * thrustForce;
            rb.AddForce(force);
        }
    }
}
