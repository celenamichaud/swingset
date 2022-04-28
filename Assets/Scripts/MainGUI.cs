using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGUI : MonoBehaviour
{
    public MainManager manager;
    public GameObject mainPanel;
    public Button playButton;
    private Text scoresText;

    // Start is called before the first frame update
    void Start()
    {
        // create private reference variable to ScoresText in panel
        foreach (Text comp in mainPanel.GetComponentsInChildren<Text>())
        {
            if (comp.gameObject.name == "ScoresText")
            {
                this.scoresText = comp;
            }
        }
        scoresText.text = MakeScoreList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateScores()
    {
        scoresText.text = MakeScoreList();
    }

    private string MakeScoreList()
    {
        string scoreList = "Previous Scores: \n";
        foreach (int score in manager.gameScores)
        {
            scoreList = scoreList + score + "\n";
        }
        return scoreList;
    }

    public void HandlePlayButton()
    {
        StartCoroutine(PlayGame(3));
    }

    IEnumerator PlayGame(float delay)
    {
        playButton.interactable = false;

        Text buttonText = playButton.GetComponentInChildren<Text>();

        while (delay > 0)
        {
            buttonText.text = "" + delay;
            delay -= 1;
            yield return new WaitForSeconds(1);
        }

        // START GAME HERE... LOAD SCENE?
        mainPanel.SetActive(false);
        playButton.interactable = true;
        buttonText.text = "PLAY";
    }
}
