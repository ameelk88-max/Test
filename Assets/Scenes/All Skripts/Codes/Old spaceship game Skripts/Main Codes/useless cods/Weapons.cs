using UnityEngine;

public class Weapons : MonoBehaviour
{
    private Collider2D thisCollider;
    public KeyCode attackButton;
    HP hp = new HP();
    public string nameW;
    public int damage;
    public float cooldown;
    public GameObject player1;
    public GameObject player2;

    void start() 
    {
     thisCollider = GetComponent<Collider2D>();
    }
    public virtual void Attack()
    {
      if (Input.GetKeyDown(attackButton) && thisCollider.CompareTag("Player"))
      {
        
        hp.currentHP = hp.currentHP - damage;
     
      }
}
public class Sword : Weapons 
{
    private void Awake()
    {
        nameW = "Sword";
        damage = 25;
        cooldown = 5;
    }
}
public class Arrows : Weapons 
{
    private void Awake()
    {
        nameW = "Sword";
        damage = 25;
        cooldown = 5;
    }
}
public class knife :Weapons
{
    private void Awake()
    {
        nameW = "Knife";
        damage = 25;
        cooldown = 5;
    }
}

public class Hammer : Weapons 
{
    private void Awake()
    {
        nameW = "Hammer";
        damage = 25;
        cooldown = 5;
    }
}
}