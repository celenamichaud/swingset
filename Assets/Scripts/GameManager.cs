using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        // ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(goalScored());
    }
    IEnumerator goalScored()
    {
        Debug.Log(ball.GetComponent("Goal"));
        if (ball.GetComponent("Goal") == true)
        {
            Debug.Log("Goal is scored!");
            yield return new WaitForSeconds(5);
            Debug.Log("Return ball to start...");
            // call ball.resetPos and restart game?
            // how can I write Ball.cs so I can set goal to false?
            //ball.Goal = false;
        }
        
    }
}
