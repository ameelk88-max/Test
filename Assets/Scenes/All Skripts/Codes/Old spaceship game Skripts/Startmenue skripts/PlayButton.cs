using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PressPlay()
    {
        SceneManager.LoadScene(1);

    }

}