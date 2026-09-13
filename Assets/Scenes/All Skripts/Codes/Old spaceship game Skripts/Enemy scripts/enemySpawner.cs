using JetBrains.Annotations;
using NUnit.Framework.Internal;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    // make 2 Variables to control the time until new enemy spawn
    public float currenttime;
    public float interval;

    // References for all enemys
    public GameObject enemyObject; //30%
    public GameObject smallEnemy;  // 20% 
    public GameObject largeEnemy;  // 20%
    public GameObject trickyenemy; // 25% 
    public GameObject bossenemy; //5%

    // mache Referrenzen für die Spawners 
    public GameObject sp1;
    public GameObject sp2;
    public GameObject sp3;
    public GameObject sp4;
    public GameObject sp5;
    public List<GameObject> spawners = new List<GameObject>(); // a list for all spawners
    public GameObject temp;





    private void Start()
    {
        // Alle Spawners in Liste packen
        spawners.Add(sp1);
        spawners.Add(sp2);
        spawners.Add(sp3);
        spawners.Add(sp4);
        spawners.Add(sp5);


    }

    private void Update()

    { // spawn enemys in constant intervalls
        if (Time.time >= currenttime)
        {
            ToSpawn();

            // 20% chance to spawn one more enemy
            int tempo = Random.Range(1, 11);
            if (tempo == 1 || tempo == 2)
            {
                ToSpawn();
            }
            // 0,5% chance to spawn 4 more enemys at once
            if (Random.value < 0.005f) 
            {
                ToSpawn(); ToSpawn(); ToSpawn(); ToSpawn();
            }
        }
    }

    // Spawn enemys at random spawners
    public void ToSpawn()
    {
        currenttime = Time.time + interval; // spawn enemys after interval time
        // choose a random spawner from the 5
        int index = Random.Range(0, 5);
        temp = spawners[index];



        // get random number to spawn enemys based on random numbers
        int rnd = Random.Range(1, 101);

        switch (rnd)
        {
            // 5% chance to spawn the boss
            case > 0 and <= 5:
                Instantiate(bossenemy, temp.transform.position, temp.transform.rotation);
                break;
            // 30% chance to spawn the boss
            case > 5 and <= 35:
                Instantiate(enemyObject, temp.transform.position, temp.transform.rotation);
                break;
            // 20% chance to spawn the boss
            case > 35 and <= 55:
                Instantiate(smallEnemy, temp.transform.position, temp.transform.rotation);
                break;
            // 20% chance to spawn the boss
            case > 55 and <= 75:
                Instantiate(trickyenemy, temp.transform.position, temp.transform.rotation);
                break;
            // 25% chance to spawn the boss
            case > 75 and <= 100:
                Instantiate(largeEnemy, temp.transform.position, temp.transform.rotation);
                break;
        }



    }

    //Variables for the following Evolution() methode
    public int largeEnemyHPIncrease = 25;
    
    public int normalenemyHPIncrease = 25;
    public float normalenemySpeedIncrease = 0.3f;

    public float smallEnemySpeedincrease = 0.5f;

    public int bossenemyHpIncrease = 100;

    public float trickySpeedIncrease = 10f;
    public int trickyHPIncrease = 10;

    // every enemy type gains a uniqe upgrade after the player reaches x score.

    [ContextMenu("Evolution Methode")]
    public void Evolution()
    {
        
        // increase big enemys hp by 25
        largeEnemy.GetComponent<EnemyHP>().maxHP += largeEnemyHPIncrease; 
        
        // Increase maxHp and speed of normal enemy a little
        enemyObject.GetComponent<EnemyHP>().maxHP += normalenemyHPIncrease;
        enemyObject.GetComponent<EnemyMovement>().enemySpeed += normalenemySpeedIncrease;

        //Increase smallenemy speed greatly
        smallEnemy.GetComponent<EnemyMovement>().enemySpeed += smallEnemySpeedincrease;

        //Increase trickyenemy stats
        trickyenemy.GetComponent<EnemyMovement>().enemySpeed += trickySpeedIncrease;
        trickyenemy.GetComponent<EnemyHP>().maxHP += trickyHPIncrease;

        //Increase Bossenemy HP greatly
        bossenemy.GetComponent<EnemyHP>().maxHP += bossenemyHpIncrease;
    }
    
}
