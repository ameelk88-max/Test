using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 2f;

    // controlling how fast the enemy will become after x time
    public float timeUntilSpeedup = 5f;
    public float speedUpValue = 1f;
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { // enemy moves
        transform.position += Vector3.down * enemySpeed * Time.deltaTime;

        //after sometime enemy will become faster
        if (Time.time >= timeUntilSpeedup) 
        {
            timeUntilSpeedup = Time.time + timeUntilSpeedup;
            enemySpeed = enemySpeed + speedUpValue;
        }
    }

  
}
