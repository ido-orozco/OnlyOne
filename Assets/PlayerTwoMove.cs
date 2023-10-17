using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTwoMove : MonoBehaviour
{
    // Start is called before the first frame update
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
    public void testfn()
    {
        speed = speed * .9f;
    }
    void ProcessInputs()
    {
        float moveX=0;
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
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1;
        }
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
