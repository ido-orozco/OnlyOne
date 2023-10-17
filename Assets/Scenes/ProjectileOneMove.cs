using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ProjectileOneMove : MonoBehaviour
{
    // Start is called before the first frame update
    Boolean SpawnProjectile;
    public GameObject ProjectileOne;
    public GameObject OtherPlayer;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    Boolean HasProjectileSpawnedYet = false;
    public float ProjectileSpeed;
    void Update()
    {
        GameObject Player= GameObject.Find("Playa");
        Boolean SpawnProjectile = Player.GetComponent<ItemCollection>().SpawnProjectileOne;
        Transform PlayerTransform = Player.transform;
        Transform OtherPlayerTransform = OtherPlayer.transform;
        Transform ProjectileOneTransform= ProjectileOne.transform;
        if (SpawnProjectile && HasProjectileSpawnedYet==false)
        {
            Debug.Log("Projectile Spawned");
            GameObject CloneProjectile= Instantiate(ProjectileOne, PlayerTransform.position, PlayerTransform.rotation);
            Debug.Log(CloneProjectile);
            Vector2 direction = (OtherPlayerTransform.position - transform.position).normalized;
            Vector2 movement = direction * ProjectileSpeed*Time.deltaTime;
            CloneProjectile.GetComponent<Transform>().Translate(movement);
            SpawnProjectile = false;
            HasProjectileSpawnedYet= true;
        }
       
    }
           

    }

