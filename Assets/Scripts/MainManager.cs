using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public int[] gameScores; // scores of the last 5 games
    private int gameIndex;
    public MainGUI mainGUI;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        gameScores = new int[5];
        gameIndex = 0;
        
    }

    public void UpdateScore(int goals)
    {
        gameScores[gameIndex] = goals;
        gameIndex++;
        Debug.Log("Game number " + gameIndex + "'s score is being updated to " + goals);
        // For now, game overwrites scores as they update. Could implement "leaderboard" here.
        if (gameIndex == 5) {
            gameIndex = 0;
        }
        mainGUI.UpdateScores();
    }

   
}
