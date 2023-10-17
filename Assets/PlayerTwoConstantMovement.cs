using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTwoConstantMovement : MonoBehaviour
{
    public float speed;
    private float cameraSpeed = 5;
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
        float moveY=0;
        
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("forward");
            moveY = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1;
        }

        moveDirection = new Vector2(0, moveY);


    }
    void Move()
    {

        rb.velocity = new Vector2(cameraSpeed, moveDirection.y * speed);
        
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