using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.maxAngularVelocity = Mathf.Infinity; // Ball can roll as fast as possible
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}

