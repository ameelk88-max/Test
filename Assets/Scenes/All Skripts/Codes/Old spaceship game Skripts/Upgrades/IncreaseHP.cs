using UnityEngine;

public class IncreaseHP : MonoBehaviour
{
    // game manager Reference cause you need to change lifes
    public GameManager rf;
    


    public void GainHP() 
    {
        rf.Lifes += 2;
    }
}
