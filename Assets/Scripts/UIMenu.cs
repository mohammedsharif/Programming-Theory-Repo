using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMenu : MonoBehaviour
{
    public TextMeshProUGUI startButton;
    public TextMeshProUGUI bestPlaysButton;
    public TextMeshProUGUI quitButton;
    public TMP_InputField playerName;

    private void Start() 
    {
        playerName.text = "Working";    
    }

    //load game scene
    public void StartNew()
    {
        Debug.Log("Start button clicked");
    }

    //quit the application
    public void QuitGame()
    {
        Debug.Log("Quit button clicked");
    }

    //go to score board scene
    public void BestPlays()
    {
        Debug.Log("Best Plays button clicked");
    }
}
