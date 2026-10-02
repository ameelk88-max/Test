using UnityEngine;

public class GamaManager : MonoBehaviour
{
    public static GamaManager instance; // a reference


     void Awake()
    {
        if (instance == null) 
        { 
         instance = this;    // this game Object is the game mananger 
        }
        else
        { 
            Destroy(this); 
        }
    }
}


