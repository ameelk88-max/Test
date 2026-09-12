using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradesManager : MonoBehaviour
{
    //References for all Buttons
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    private List<Button> allButtons; // make alist for the buttons which are upgrades!
    //References for all buttons Locations (Spawners from type transform) 
    public Transform bttonSpawner1;
    public Transform bttonSpawner2;
    public Transform bttonSpawner3;
    private List<Transform> allSp; // list for all spawners
    // reference for GameManager
    public GameManager GMR;

    private void Awake()
    {
        allButtons = new() { button1, button2, button3, button4 }; //define the elements of this List you can add mroe buttons here in future
        allSp = new() { bttonSpawner1, bttonSpawner2, bttonSpawner3 };// the three buttonspawners locations are here
    }
    // make three upgrade appear

   






    private void Update()
    {





        if(GMR.upgradesDetecter ==4 || GMR.upgradesDetecter %8 ==0) 
        {
            Upgrades();
            GMR.upgradesDetecter += 1;
        }
    }







    [ContextMenu ("Upgrades methode")]
    public void Upgrades() 
    {
        //first get 3 Random index numbers to get 3 random upgrades from the list
        int index1 = 0;       
        int index2 = 0;      
        int index3 = 0;
        while(index1 == index2 || index1 == index3 || index2 == index3) 
        {
            index1 = Random.Range(0, allButtons.Count);
            index2 =  Random.Range(0, allButtons.Count);
            index3 =  Random.Range(0, allButtons.Count);
        }

        //now make the 3 random buttons in the list active
        allButtons[index1].gameObject.SetActive(true);
        allButtons[index2].gameObject.SetActive(true);
        allButtons[index3].gameObject.SetActive(true);

        // change the 3 random buttons positions to appear in right place
        allButtons[index1].transform.position = bttonSpawner1.position;
        allButtons[index2].transform.position = bttonSpawner2.position;
        allButtons[index3].transform.position = bttonSpawner3.position;
    }

    // Set all Buttons to inactive. Helps after a player pick an upgrade
    public void DeactivateALLButtons()
    {
     foreach(Button button in allButtons) 
        {
         button.gameObject.SetActive(false);
        }
    
    }









}
