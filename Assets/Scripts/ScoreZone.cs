using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private bool goal = true;

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
        if (goal) {
            Debug.Log("A goal was scored!");
            // other.transform.position // move ball back to starting position
            goal = false;
        } else
        {
            Debug.Log("This goal was already counted.");
        }
    }

}
