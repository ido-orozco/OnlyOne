using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCollection : MonoBehaviour
{
    // Start is called before the first frame update
    Boolean ItemOne;
    public Boolean SpawnProjectileOne;
    void Start()
    {
        ItemOne = false;
        SpawnProjectileOne = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject otherPlayer = GameObject.Find("PlayaTwo");
        if (ItemOne)
        {
            if (Input.GetKey(KeyCode.L))
            {
                
                otherPlayer.GetComponent<PlayerTwoMovement>().testfn();
                ItemOne = false;
                SpawnProjectileOne = true;
            }
            else
            {
                
                
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "ItemOne")
        {
            
            ItemOne = true;
            GameObject Triangle = GameObject.Find("ItemOne");
            Triangle.GetComponent<SpriteRenderer>().enabled = false;

        }
        //Playa.gameObject.SetActive(false);
    }
}
