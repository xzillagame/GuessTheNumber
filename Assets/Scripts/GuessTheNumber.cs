using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GuessTheNumber : MonoBehaviour
{

    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField input;


    int randomNumGenerated;


    // Start is called before the first frame update
    void Start()
    {
        header.text = "Guess the Number!";
        GameSetup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameSetup()
    {
        randomNumGenerated = Random.Range(0, 11);
    }
    
    public void ResetGame()
    {
        input.text = "";
    }


}
