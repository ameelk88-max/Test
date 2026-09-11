using UnityEngine;

public class HP : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage (int damage) 
    {
        currentHP = currentHP - damage;
    }
}
