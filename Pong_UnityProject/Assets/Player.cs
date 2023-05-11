using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField]
    KeyCode up = KeyCode.W;
    [SerializeField]
    KeyCode down = KeyCode.S;
    [SerializeField]
    float velocity = 4f;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = Vector2.zero;
        if (Input.GetKey(up))
            rb.velocity += Vector2.up * velocity;
        if (Input.GetKey(down))
            rb.velocity += Vector2.down * velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball == null)
            return;
        ball.rb.velocity = ( (ball.transform.position.y - gameObject.transform.position.y) * 2f * Vector2.up + (Vector2.left * this.transform.position.x).normalized).normalized * ball.velocity;
    }
}
