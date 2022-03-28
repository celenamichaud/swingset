using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGUI : MonoBehaviour
{
    public GameManager manager;
    public GameObject hudPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.gameStarted)
        {
            hudPanel.SetActive(true); // hide HUD until game starts
        }

        //TODO: add end game button
    }

    public void UpdateGoals(int numGoals)
    {
        StartCoroutine(IncreaseGoals(numGoals));
    }

    IEnumerator IncreaseGoals(int numGoals)
    {
        Text buttonText = hudPanel.GetComponentInChildren<Text>();

        buttonText.text = "Goals: " + numGoals;

        yield return null;
    }

}
