using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GuessTheNumber : MonoBehaviour
{
    
    //Seralized Files for a header to display text to user and an input field for user input
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField input;

    //Variables for storing the random number generaterd, maximum tries allowed, and initlaizing current count to maximum count
    // as well as bool for if the game has been finished
    int randomNumGenerated;
    const int MAXCOUNTER = 3;
    int curr_counter = MAXCOUNTER;
    bool gameFinished = false;


    // Start is called before the first frame update
    void Start()
    {   
        GameSetup();
    }

    void GameSetup()
    {
        //Set game state to not finished
        gameFinished = false;

        //Reset current counter
        curr_counter = MAXCOUNTER;

        //Roll random number for guessing
        randomNumGenerated = Random.Range(0, 11);

        //Update header text for user, welcoming to game and how many tries they have
        header.text = "Try and Guess the Number!\n You have " + curr_counter + " tries!";

        //Clear the input field
        input.text = "";
    }
    

    //ResetGame() called from reset game button
    public void ResetGame()
    {
        //Clear Input field on Reset game Button being pressed and call GameSetup to restart game
        input.text = "";
        GameSetup();
    }


    //SubmitAnswer() called from answer submission button
    public void SubmitAnswer()
    {

        //If game state is finished from player either winning or losing, return out of sumbmit immediately
        if (gameFinished) return;
        

        //Parse the string from input and compare if int is the random int 
        if(int.Parse(input.text) == randomNumGenerated)
        {
            //Player won, game is now finished and update header text to inform user of winning and how to restart
            
            gameFinished = true;
            header.text = "You WON!! Press Reset Game to try again!";
        }
        else
        {

            //Decrease current attempts left
            curr_counter -= 1;

            //Check if current attemps left is at 0, if so, player lost game
            if(curr_counter == 0)
            {
                //Player lost, game is now finished and update header to inform user of lose and how to restart

                gameFinished = true;
                header.text = "Sorry, you LOST the game. Try again by pressing the Reset Game button!";
            }
            else
            {
                //Display to user the answer was wrong and how many attemps they have left
                header.text = "Sorry the answer was wrong. You have " + curr_counter + " tries left";
            }

        }
    }


}
