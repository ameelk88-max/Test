using UnityEngine;

public class IncreaseHP : MonoBehaviour
{
    // game manager Reference cause you need to change lifes and upgrades Manager ref
    public GameManager rf;
    public UpgradesManager upg; 


    public void GainHP() 
    {
        rf.Lifes += 2;

        this.gameObject.SetActive(false);
        upg.DeactivateALLButtons();
    }
}
