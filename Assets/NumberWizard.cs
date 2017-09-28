using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {


	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 10;

	public Text NumberWizardText;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame (){
		max = 1000;
		min = 1;
		NextGuess

		NumberWizardText.text = guess.ToString();
		print("===============================");
		print ("Welcome to number wizard");
		print ("Pick a number in your head but don't tell me.");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick " + min);

		print ("Is the number higher or lower than " + guess +"?");
		print (" Up = higher, down = lower, enter = equals");

		max = max + 1;
	}

	void NextGuess (){
			guess = Random.Range(min, max);
			print ("Higher or lower than " + guess + "?");
			print (" Up = higher, down = lower, enter = equals");


			NumberWizardText.text = guess.ToString();
			maxGuessesAllowed = maxGuessesAllowed = 1;

			if(maxGuessesAllowed <= 0) {
				Application.LoadLevel("Win");
			}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void GuessHigher(){
		min = guess;
		NextGuess();
	}

	public void GuessLower(){
		max = guess;
		NextGuess();
	}

}
