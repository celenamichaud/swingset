using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public GameManager manager;
    private bool goalScored = false;
    // private bool goal = true;

    // public bool Goal { get => goal; set => goal = value; }

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
        Rigidbody rb = other.attachedRigidbody;
        if(rb == null) { return; }
        Ball b = rb.GetComponent<Ball>();
        if(b == null) { return; }
        if (!goalScored)
        {
            goalScored = true;
            manager.goalScored(this,b);
        }
    }


    public void resetGoal()
    {
        goalScored = false;
    }

}
