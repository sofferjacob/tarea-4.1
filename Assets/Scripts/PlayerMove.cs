using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 move;
    Rigidbody2D rb2d;

    Level level;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        level = GetComponent<Level>();
        move.x = Input.GetAxis("Horizontal") * (speed * (level.GetLevel() * 0.2f));
        move.y = Input.GetAxis("Vertical") * (speed * (level.GetLevel() * 0.2f));
        rb2d.velocity = move;
    }
}
