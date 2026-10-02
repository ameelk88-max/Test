using JetBrains.Annotations;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Abilitys : MonoBehaviour
{
    [SerializeField] public int damage = 10;
    [SerializeField] public string nameAbility;
    [SerializeField] public float cdr = 1f;
    [SerializeField] public float timeNext = 0f; 
    public virtual void Activate() { }
}

public class Fireball : Abilitys 
{
    private void Awake()
    {
        damage = 30;
        cdr = 2f;
    }

    public override void Activate()
    {
        base.Activate();
    }
}