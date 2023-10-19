using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTwo3WayMovement : MonoBehaviour
{
    public float speed;
    public float brakeFactor;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    void Update()
    {
        ProcessInputs();
    }
    void FixedUpdate()
    {
        Move();
    }

    public void testfn()
    {
        speed = speed * .9f;
    }

    void ProcessInputs()
    {
        float moveY = 0;
        float moveX = 1;
        
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1 * brakeFactor;
        }

        moveDirection = new Vector2(moveX, moveY);


    }
    void Move()
    {

        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Monsta")
        {
            Debug.Log("Death");
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            SceneManager.LoadScene("Death");
        }
    }
}