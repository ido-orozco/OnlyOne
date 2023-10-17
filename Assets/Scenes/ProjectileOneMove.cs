using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ProjectileOneMove : MonoBehaviour
{
    // Start is called before the first frame update
    Boolean SpawnProjectile;
    public GameObject Player;
    public GameObject ProjectileOne;
    public GameObject OtherPlayer;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
   
    public float ProjectileSpeed;
    void Update()
    {
    }

    public void shootProjectile() { 
        Transform PlayerTransform = Player.transform;
        Transform OtherPlayerTransform = OtherPlayer.transform;
        Transform ProjectileOneTransform= ProjectileOne.transform;
        GameObject CloneProjectile;
        CloneProjectile= Instantiate(ProjectileOne, PlayerTransform.position, PlayerTransform.rotation);
            Vector2 direction = (OtherPlayerTransform.position - PlayerTransform.position).normalized;
            Vector2 movement = direction * ProjectileSpeed * Time.deltaTime;
        // CloneProjectile.GetComponent<SpriteRenderer>().enabled = false;
        //CloneProjectile.GetComponent<Transform>().Translate(movement);
        Debug.Log(movement);
        CloneProjectile.GetComponent<Rigidbody2D>().velocity=movement;
        }
    }       

    

