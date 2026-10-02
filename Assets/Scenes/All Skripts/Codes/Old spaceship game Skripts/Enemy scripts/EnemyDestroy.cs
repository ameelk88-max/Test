using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    // destroy things on empact
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finishline")) { Destroy(this); }
    }
}
