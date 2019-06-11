using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [SerializeField]
    private InputField input;
    [SerializeField]
    private Text text;
    [SerializeField]
    private GameObject button;
    [SerializeField]
    private GameObject music;
    [SerializeField]
    private GameObject beatlesButton;
    [SerializeField]
    private GameObject musicBeatles;
    [SerializeField]
    private GameObject stonesButton;
    [SerializeField]
    private GameObject musicStones;
    [SerializeField]
    private GameObject textTwo;
    

    private int number;
    private int countGuesses;

    //start game
    void Awake()
    {
        number = Random.Range(0, 101);
        text.text = "Guess a number between 0 and 100!";
        Debug.Log("wylosowany: " + number);

    }

    public void GetInput(string guessNumber)
    {
        CompareGuesses(int.Parse(guessNumber));
        Debug.Log("entered: + " + guessNumber);
        input.text = " "; //clear guess
        countGuesses++;
        
    }

    public void CompareGuesses(int guessNumber)
    {

        if (guessNumber == number)
        {
            text.text = "Correctly! The number is " + number + ". You needed " + countGuesses + " trials for that. Do you want to play again?";
            button.SetActive(true);
            music.SetActive(true);
            beatlesButton.SetActive(true);
            stonesButton.SetActive(true);
            textTwo.SetActive(true);
        }
        else if (guessNumber < number)
        {
            text.text = "The correct number is BIGGER then your guess. Keep trying!";
        }
        else if (guessNumber > number)
        {
            text.text = "The correct number is SMALLER then your guess. Keep trying!";
        }
    }

        public void PlayAgain()
    {
        number = Random.Range(0, 101);
        text.text = "Guess a number between 0 and 100!";
        countGuesses = 0;
        button.SetActive(false);
        beatlesButton.SetActive(false);
        stonesButton.SetActive(false);
        textTwo.SetActive(false);
    }

    public void PlayBeatles()
    {
        musicBeatles.SetActive(true);
    }

    public void PlayStones()
    {
        musicStones.SetActive(true);
    }

}
