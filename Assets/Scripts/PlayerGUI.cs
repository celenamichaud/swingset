using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGUI : MonoBehaviour
{
    public GameManager manager;
    public GameObject hudPanel;
    public Button stopButton;
    public Text goalsDisplay;

    // Start is called before the first frame update
    void Start()
    {
        Text stopButtonText = stopButton.GetComponentInChildren<Text>();
        stopButtonText.text = "STOP";
    }

    // Update is called once per frame
    void Update()
    {
        if (!manager.gameStarted)
        {
            hudPanel.SetActive(false); // hide HUD until game starts
        } else
        {
            hudPanel.SetActive(true);
        }

        //TODO: add end game button
    }

    public void UpdateGoals(int numGoals)
    {
        goalsDisplay.text = "Goals: " + numGoals;
    }

    public void HandleStopButton()
    {
        // stop game in GameManager?
        // display player stats
        // considering hiding button then displaying text of stats, or separate panel?
        stopButton.interactable = false;

        stopButton.GetComponentInChildren<Text>().text = "STOPPED";

        // what next? restart game?

        // 4/27 - try loading main scene from here
    }

}
