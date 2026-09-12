using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class In : MonoBehaviour
{
    public Transform position; // where the bullet should spawn
    public GameObject shoot; // or body it is a game Object you add from inspector cause instaniate() needs a game Object to copy
    

    public KeyCode excute; // choose a key to use attack
    // make cooldown variables
    public float cdr = 1.5f;
    public float attackInterval; // how much time until next attack  


    private void Start()
    {
        attackInterval = Time.time;
    }
    private void Update()
    {
        //Spawn the Bullet when you press the excute-key
        if (Input.GetKeyDown(excute) && Time.time >= attackInterval)
        {
            
            GameObject newShoot = Instantiate(shoot, position.position, position.rotation);
            attackInterval = Time.time + cdr;
           
        }

    }

   
}
