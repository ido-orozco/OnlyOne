using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsta : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

}
