using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFase2 : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10;
    public float deadZone = 0.1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 tilt = Input.acceleration;

        tilt.x = Mathf.Abs(tilt.x) < deadZone ? 0 : tilt.x;
        tilt.y = tilt.y < deadZone ? 0 : tilt.y;


        Vector2 direction = new Vector2(tilt.x * speed, tilt.y * speed);
        rb.velocity = direction;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Plataforma"))
        {
            GameManager.Instance.Checklanding.Invoke(rb.velocity.y);
        }
    }
}
