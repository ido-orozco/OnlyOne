using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerOneConstantMovement : MonoBehaviour
{
    public float speed;
    private float cameraSpeed = 5;
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
        rb.velocity = new Vector2(cameraSpeed, moveDirection.y * speed);
    }
    void ProcessInputs()
    {
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(0, moveY);
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