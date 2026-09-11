using UnityEngine;
using UnityEngine.UIElements;

public class Hitbox : MonoBehaviour
{
    public float radius = 1f;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,radius);
    }
}
