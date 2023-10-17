using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCollection : MonoBehaviour
{

    Boolean playerHasItemOne;
    void Start()
    {
        playerHasItemOne = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject otherPlayer = GameObject.Find("PlayaTwo");
        

        if (playerHasItemOne && Input.GetKey(KeyCode.L))
        {
            // Shoot bullet
            this.GetComponent<ProjectileOneMove>().shootProjectile();

            // Slow down player
            otherPlayer.GetComponent<PlayerTwoMovement>().testfn();

            // Remove ability
            playerHasItemOne = false;
            
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // When player collects the item, 
        if (collision.gameObject.name == "ItemOne")
        {
            // collect it
            playerHasItemOne = true;

            // make it disappear
            GameObject Triangle = GameObject.Find("ItemOne");
            Triangle.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
