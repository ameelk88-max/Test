using UnityEngine;

public class In : MonoBehaviour
{
    public Transform position; // where the bullet should spawn
    public GameObject shoot; // or body it is a game Object you add from inspector cause instaniate() needs a game Object to copy
    

    public KeyCode excute; // choose a key to use attack


   
    private void Update()
    {
        //Spawn the Bullet when you press the excute-key
        if (Input.GetKeyDown(excute))
        {
            
            GameObject newShoot = Instantiate(shoot, position.position, position.rotation);
            
           
        }

    }
}
