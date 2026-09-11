using UnityEngine;

public class ShootMove : MonoBehaviour
{
    //Eigenschaften der Schüsse 
    public float bulletSpeed = 5f;
    public int bulletDamage = 35;
    private void Start()
    {
        
    }

   
    
    
    // Update is called once per frame
    void Update()
    {
        //moving the bullet
        transform.position += Vector3.up * bulletSpeed * Time.deltaTime;

    }
    //destroy it when it enter a domain
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
