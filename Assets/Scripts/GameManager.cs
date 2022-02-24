using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Ball ball;
    public Transform startLocation;
    public Ball ballPrefab;
    int _numGoals;
    public int numGoals
    {
        get { return _numGoals; }
        private set { _numGoals = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        // ball = GameObject.Find("Ball");
        numGoals = 0;
        ball = Instantiate<Ball>(ballPrefab, startLocation.position, startLocation.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(goalScored());
    }
    public void goalScored(ScoreZone zone, Ball b)
    {
        //Debug.Log(ball.GetComponent("Goal"));
        //if (ball.GetComponent("Goal") == true)
        //{
        //    Debug.Log("Goal is scored!");
        //    yield return new WaitForSeconds(5);
        //    Debug.Log("Return ball to start...");
        //    // call ball.resetPos and restart game?
        //    // how can I write Ball.cs so I can set goal to false?
        //    //ball.Goal = false;
        //}
        StartCoroutine(respawnBallIn(3.0f, b, zone));
        
        
    }

    IEnumerator respawnBallIn(float time,Ball b, ScoreZone zone)
    {
        yield return new WaitForSeconds(time);
        b.transform.position = startLocation.position;
        b.transform.rotation = startLocation.rotation;
        b.GetComponent<Rigidbody>().velocity = Vector3.zero;
        b.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        zone.resetGoal();
        yield return null;
    }
}
