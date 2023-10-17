using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileOneMove : MonoBehaviour
{
    // Start is called before the first frame update
    Boolean SpawnProjectile;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player= GameObject.Find("Playa");
        Boolean SpawnProjectile = Player.GetComponent<ItemCollection>().SpawnProjectileOne;
        if (SpawnProjectile)
        {
            Debug.Log("Projectile Spawned");
            
        }
           

    }
}
