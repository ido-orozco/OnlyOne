using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float leftSpeedFactor;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
   

    // Update is called once per frame
    void Update()
    {
        ProcessInputs(); 
        
    }
    void FixedUpdate()
    {
        Move();
    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);


    }
    void Move()
    {
        if (moveDirection.x < 0)
        {
            rb.velocity = new Vector2(moveDirection.x * speed * leftSpeedFactor, moveDirection.y * speed);

        }
        else
        {
            rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Monsta")
        {
            Debug.Log("Death");
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            SceneManager.LoadScene("Death");
        }
        //Playa.gameObject.SetActive(false);
    }
}
