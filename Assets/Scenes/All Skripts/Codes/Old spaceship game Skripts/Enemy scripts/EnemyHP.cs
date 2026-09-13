using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEditor.Macros;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHealth;
   //Referrenz  für die Eigenschaften der Schüße. In Inspector muss das hinzugefügt  werden
    public ShootMove refr;
    // GameManagerref 
    public GameManager gm;
    // reference of enemySpawner
    [SerializeField] private enemySpawner spRefr;
    private void Start()
    {
        currentHealth = maxHP;
        
    }


    public void TakeDamage(int damage) 
    {
     currentHealth = currentHealth - damage;
    
    }

    // when something hits enemy they take damage equal to the bullets damage 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("shoot"))
        {
            int temp = refr.bulletDamage;
            Debug.Log(temp);
            TakeDamage(temp);
        
            // here the enemy will be slowed equal to the bulletSlow
            this.gameObject.GetComponent<EnemyMovement>().enemySpeed -= collision.gameObject.GetComponent<ShootMove>().bulletSlow;
           
            // Make sure even if the enemy speed reaches 0 he will keep moving very slowly. Note: if enemy speed is in minus the enemy will move in the opposite direction
            if (this.gameObject.GetComponent<EnemyMovement>().enemySpeed <= 0) 
            {
                this.gameObject.GetComponent<EnemyMovement>().enemySpeed = 0.2f;
            }
            Destroy(collision.gameObject);   // destroy the bullets after hitting them
        }
    }

    private void Update()
    {// destroy enemy if it's HP reaches 0, increase score by 1 and upgradesDetecter by 1

        if (currentHealth <= 0) 
        {  
            Destroy (this.gameObject);  // destroy enemy
            gm.score++;                 // increase score by 1
            gm.upgradesDetecter++;      // increase upgradedetector by 1

            if(gm.score %7 == 0) 
            {
                spRefr.interval -= 0.1f;
            }
        }
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.CompareTag("Finishline"))
        {
            gm.Lifes -= 1;
            Destroy(this.gameObject); 
        }
    }
}
