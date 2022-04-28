using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Ball ball;
    public Transform startLocation;
    public Ball ballPrefab;
    int _numGoals;
    public bool gameStarted;
    public PlayerGUI playerGUI;
    private MainManager Instance;

    public int NumGoals // Goals scored in one game
    {
        get { return _numGoals; }
        private set { _numGoals = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        NumGoals = 0;
        // Spawn the ball at the start of the game
        // ball = Instantiate<Ball>(ballPrefab, startLocation.position, startLocation.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        StartCoroutine(Gameplay());
    }

    IEnumerator Gameplay()
    {
        gameStarted = true;
        
        ball = Instantiate<Ball>(ballPrefab, startLocation.position, startLocation.rotation);
        
        yield return null;
    }

    public void StopGame()
    {
        // call this function from PlayerGUI to stop gameplay
        // AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Scenes/Loading");
        // how to handle indexing? create another variable of index in Instance, let it update to
        // start the game?
        Instance.gameScores[0] = NumGoals;
    }

    // Called by ScoreZone trigger entry to initiate goal scoring sequence
    public void GoalScored(ScoreZone zone, Ball b)
    {
        StartCoroutine(RespawnBallIn(3.0f, b, zone));
        NumGoals++;
        playerGUI.UpdateGoals(NumGoals);
    }

    // Respawn ball in start position after X number of seconds 
    IEnumerator RespawnBallIn(float time,Ball b, ScoreZone zone)
    {
        yield return new WaitForSeconds(time);
        b.transform.SetPositionAndRotation(startLocation.position, startLocation.rotation);
        b.GetComponent<Rigidbody>().velocity = Vector3.zero;
        b.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        zone.ResetGoal();
        yield return null;
    }
}
