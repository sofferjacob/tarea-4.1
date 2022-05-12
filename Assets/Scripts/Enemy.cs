using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    int direction = 1;
    Vector3 vel;

    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        direction = (Random.value > 0.5f ? 1 : -1);
        rb2d = GetComponent<Rigidbody2D>();
        vel = Vector3.right * speed * direction;
        rb2d.velocity = vel;
    }

    void SwitchDirection()
    {
        direction *= -1;
        vel = Vector3.right * speed * direction;
        rb2d.velocity = vel;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Level level = col.gameObject.GetComponent<Level>();
            level.GameOver();
        }
        else
        {
            SwitchDirection();
        }
    }
}
