using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    IEnumerator StartGame()
    {
        startButton.interactable = false;
        yield return new WaitForSeconds(1);
    }
}
