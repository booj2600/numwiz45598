using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int maximum = 100;
    int min = 1;
    int guess = 50;

    // Use this for initialization
    void Start () {


        Debug.Log("Welcome to number wizard");
        Debug.Log("Please select a number.");
        Debug.Log("The max number is: " + maximum);
        Debug.Log("The lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than the guess!");
        Debug.Log("Push Up for higher / Down for lower / Enter for right on!");
	}
	
	// Update is called once per frame
	void Update (){
        // Detect when up key pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (maximum + min) / 2;
            Debug.Log(guess);
        }

        // Detect when Down key pressed
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            maximum = guess;
            guess = (maximum + min) / 2;
            Debug.Log(guess);
        }

        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }
    }
}
