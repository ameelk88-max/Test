using NUnit.Framework.Internal;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
   // make 2 Variables to control the time until new enemy spawn
    public float currenttime;
    public float interval;
    public GameObject enemyObject;
  // mache Referrenzen für die Spawners 
    public GameObject sp1;
    public GameObject sp2;
    public GameObject sp3;
    public GameObject sp4;
    public GameObject sp5;
    public List<GameObject> spawners = new List<GameObject>();
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
            if(tempo == 1 ||tempo == 2) 
            {
                ToSpawn();
            }
        }
    }

    // Spawn enemys at random spawners
    public  void ToSpawn() 
    {
        currenttime = Time.time + interval;
        int index = Random.Range(0, 5);
         temp = spawners[index]; 
        
        
        Instantiate(enemyObject, temp.transform.position,temp.transform.rotation);
    
    }
}
