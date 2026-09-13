using UnityEngine;

public class SlowEffect : MonoBehaviour
{
    [SerializeField] private ShootMove refr;
    [SerializeField] private UpgradesManager upRefr;
   

    public void SlowUp() 
    {
        refr.bulletSlow += 0.4f;
        upRefr.DeactivateALLButtons();
    }

    
}
