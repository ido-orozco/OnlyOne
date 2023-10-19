using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerOne3WayMovement : MonoBehaviour
{
    public float speed;
    public float brakeFactor;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
   

    // Update is called once per frame
    void Update()
    {
        ProcessInputs(); 
        
    }
    void FixedUpdate()
    {
        // Player Movement:
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }
    void ProcessInputs()
    {
        float moveY = Input.GetAxisRaw("Vertical");
        float moveX = Input.GetAxisRaw("Horizontal");
        if (moveX == -1) {
            moveX = -1*brakeFactor;
        }
        else {
            moveX = 1;
        }
        moveDirection = new Vector2(moveX, moveY);
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
