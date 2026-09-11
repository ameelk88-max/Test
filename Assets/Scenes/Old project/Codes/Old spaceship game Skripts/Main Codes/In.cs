using UnityEngine;

public class In : MonoBehaviour
{
    public Transform position;
    public GameObject shoot; // or body it is a game Object you add from inspector cause instaniate() needs a game Object to copy
    

    public KeyCode excute;


   
    private void Update()
    {
        if (Input.GetKeyDown(excute))
        {
            
            GameObject newShoot = Instantiate(shoot, position.position, position.rotation);
            
           
        }

    }
}
