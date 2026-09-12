using UnityEngine;

public class IncreaseDamage : MonoBehaviour
{
    // make a referance to get access to Shootmove skript
    public ShootMove referenceOfDamage; // reference for the bullet to get it's damage
    public int AmountOfIcreasedDamage = 10;  // this says how much the damage of the bullets is going to increase
    [SerializeField] private UpgradesManager pg;

    // Increase the bulletdamage
    public void DamageUp() 
    {
        referenceOfDamage.bulletDamage += AmountOfIcreasedDamage;   
        this.gameObject.SetActive(false);
        pg.DeactivateALLButtons();
    }



}
