using UnityEngine;

public class IncreasePlayerSpeed : MonoBehaviour
{
    //Make reference for the Player to change his move Speed
    public Bewegung player;         // reference for player
    public float AmountOfMovement = 4f;   // how much faster 

    public void IncreaseMovementSpeed()
    {
        player.speed += AmountOfMovement;
    }

}
