using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RampController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // When WASD are hit
    void OnMove(InputValue movementValue)
    {
        Vector2 movement = movementValue.Get<Vector2>();
        movementX = movement.x;
        movementY = movement.y;
    }

    // Physics actions executed before Update
    private void FixedUpdate()
    {
        Vector3 moves = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(moves);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
