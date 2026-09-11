using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
