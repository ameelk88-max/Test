using UnityEngine;

public class SlowEffect : MonoBehaviour
{
    [SerializeField] private ShootMove refr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void SlowUp() 
    {
        refr.bulletSlow += 0.4f;

    }
}
