using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public GameManager manager;
    private bool goalScored = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // Make sure a rigidbody has hit the trigger
        Rigidbody rb = other.attachedRigidbody;
        if(rb == null) { return; }
        // Make sure the rigidbody that hit the trigger is a ball
        Ball b = rb.GetComponent<Ball>();
        if(b == null) { return; }
        // If the goal hasn't been counted yet, count it
        if (!goalScored)
        {
            goalScored = true;
            manager.GoalScored(this,b);
        }
    }


    // Used by GameManager to reset goalScored
    public void ResetGoal()
    {
        goalScored = false;
    }

}
