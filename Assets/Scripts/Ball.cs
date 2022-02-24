using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 spawnPos;
    public Quaternion spawnRot;
    public bool Goal { get; set; } = false;

    private void Awake()
    {
        // Collect spawn position and rotation before movement
        spawnPos = transform.position;
        spawnRot = transform.rotation;
    }
    // Start is called before the first frame update
    void Start()
    {
        Goal = false;
        rb.maxAngularVelocity = Mathf.Infinity; // Ball can roll as fast as possible
    }

    // Update is called once per frame
    void Update()
    {

    }

    //IEnumerator goalScored()
    //{
    //    if(goal)
    //    {
    //        Debug.Log("Goal is scored!");
    //    }
    //    yield return new WaitForSeconds(5);
    //    Debug.Log("Return ball to start...");
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ScoreZone"))
        {
            Goal = true;
            Debug.Log("Goooooooooooooooooooal");
        }
    }
}

