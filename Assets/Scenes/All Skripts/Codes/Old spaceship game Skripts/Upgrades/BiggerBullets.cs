using UnityEngine;

public class BiggerBullets : MonoBehaviour
{
    [SerializeField] private GameObject bulletrefr; // reference of the body of bullets
    public float scale; // how much bigger the size become
    [SerializeField] private UpgradesManager upRefr;// ref of updates Manager


    public void SizeUP() 
    {
        bulletrefr.transform.localScale = bulletrefr.transform.localScale * scale;
        upRefr.DeactivateALLButtons();

    }
}
