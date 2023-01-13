using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_eval : MonoBehaviour
{
   public Text Result;
   public Image AIChoice;
   

   public string[] Choices;
   public Sprite Rock, Paper, Scissors;
   

   public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0,Choices.Length)];

        switch(randomChoice)
            {
                case "Rock":
                    switch(myChoice)
                        {
                            case "Rock":
                            Result.text = "Tie";
                            break;

                            case "Paper":
                            Result.text = "Win";
                            break;

                            case "Scissors":
                            Result.text = "Loss";
                            break;

                        }
                    AIChoice.sprite = Rock;
                    break;

                case "Paper":
                    switch(myChoice)
                        {
                            case "Rock":
                            Result.text = "Loss";
                            break;

                            case "Paper":
                            Result.text = "Tie";
                            break;

                            case "Scissors":
                            Result.text = "Win";
                            break;

                        }
                    AIChoice.sprite = Paper;
                    break;
                
                case "Scissors":
                    switch(myChoice)
                        {
                            case "Rock":
                            Result.text = "Win";
                            break;

                            case "Paper":
                            Result.text = "Loss";
                            break;

                            case "Scissors":
                            Result.text = "Tie";
                            break;

                        }
                    AIChoice.sprite = Scissors;
                    break;

            }

    }

   
}
