using UnityEngine;

public class onClick : MonoBehaviour
{
    // make a referance to get access to Shootmove skript
    public ShootMove referenceOfDamage; // reference for the bullet to get it's damage
    public int AmountOfIcreasedDamage = 10;  // this says how much the damage of the bullets is going to increase
   //Increase the damage of the bullets by increasíng their variable bulletDamage
    public void IncreaseDamage()
    {
        referenceOfDamage.bulletDamage += AmountOfIcreasedDamage;
        
    }

    public void IncreaseMovementSpeed() 
    {
    
    }

    public void IncreaseAttackSpeed() 
    {
    
    }

}
