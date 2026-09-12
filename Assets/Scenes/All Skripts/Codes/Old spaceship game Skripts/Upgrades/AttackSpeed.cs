using UnityEngine;

public class AttackSpeed : MonoBehaviour
{
   // make reference for in skript
   public In something;
    public float reduceCDR = 0.1f; // reduce the cdr buy this ammount so attacks interval become smaller

    public void IncreaseAttackSpeed() 
    {
     something.cdr -= reduceCDR;
    }
}
