using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCollection : MonoBehaviour
{
    // Start is called before the first frame update
    Boolean ItemOne;
    void Start()
    {
        ItemOne = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject otherPlayer = GameObject.Find("PlayaTwo");
        if (ItemOne)
        {
            if (Input.GetKey(KeyCode.L))
            {
                Debug.Log("speedup");
                otherPlayer.GetComponent<PlayerTwoMove>().testfn();
                ItemOne = false;
            }
            else
            {

                Debug.Log("else");
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "ItemOne")
        {
            Debug.Log("Collected Item 1");
            ItemOne = true;
            GameObject Triangle = GameObject.Find("ItemOne");
            Triangle.GetComponent<SpriteRenderer>().enabled = false;

        }
        //Playa.gameObject.SetActive(false);
    }
}
