using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportRight;
    public Transform teleportLeft;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered");
        if (other.CompareTag("LeftEdge")) 
        {
            this.transform.position = teleportRight.position;
        }
        else if (other.CompareTag("RightEdge"))
        {
            this.transform.position = teleportLeft.position;
        }


    }
}
