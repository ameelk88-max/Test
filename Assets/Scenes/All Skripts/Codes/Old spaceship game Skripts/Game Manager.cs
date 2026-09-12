using NUnit.Framework;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{  //Important variables
    public int score = 0;  // count number of enemies you kill
    public int upgradesDetecter = 0;  // detect when to use the Methode Upgrades 
    public int Lifes = 5; // count your life
    public int numberOfEnemy = 0; // how many enemies currently exist

    // Spawners referances
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject spawner5;


    public TextMeshProUGUI currentScore; // use this to write the current score
    public TextMeshProUGUI currentLifes; // use this to write the current Lifes
    private void Update()
    {
        currentScore.text = score.ToString();
        currentLifes.text = Lifes.ToString();
        // Active choose upgrade methode when you kill 10 enemy
        if (score == 10) 
        {
            /*
         ChooseUpgrades();
            */
        }
        // lóse the game when you have no more life points
        if (Lifes <= 0) 
        {
            Time.timeScale = 0f;
        }


    }


    // Stop the game to choose upgrades
    /*
    public void ChooseUpgrades() 
    {
        Time.timeScale = 0f;
    }
    */
    public void GameOver() 
    {   
        Time.timeScale = 0f;  
    }
}
