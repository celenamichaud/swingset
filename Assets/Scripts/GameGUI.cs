using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGUI : MonoBehaviour
{
    public GameManager manager;
    public GameObject menuPanel;
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!manager.gameStarted)
        {
            menuPanel.SetActive(true);
        }  
    }

    public void HandlePlayButton()
    {
        StartCoroutine(PlayGame(3));
    }

    IEnumerator PlayGame(float delay)
    {
        startButton.interactable = false;

        Text buttonText = startButton.GetComponentInChildren<Text>();

        while(delay > 0)
        {
            buttonText.text = "" + delay;
            delay -= 1;
            yield return new WaitForSeconds(delay);
        }

        manager.StartGame();
        menuPanel.SetActive(false);
        startButton.interactable = true; 
        buttonText.text = "PLAY";
    }
}
