using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int maximum;
    int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maximum = 100;
        min = 1;
        guess = 50;

        Debug.Log("Welcome to number wizard!");
        Debug.Log("Please mentally select a number.");
        Debug.Log("The max number is: " + maximum);
        Debug.Log("The lowest number is: " + min);
        Debug.Log("I demand you tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up for higher / Down for lower / Enter for right on!");
        maximum = maximum + 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Detect when up key pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        // Detect when Down key pressed
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maximum = guess;
            NextGuess();
        }

        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("We guessed it!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (maximum + min) / 2;
        Debug.Log("Is your guess higher or lower than: " + guess);
    }
}