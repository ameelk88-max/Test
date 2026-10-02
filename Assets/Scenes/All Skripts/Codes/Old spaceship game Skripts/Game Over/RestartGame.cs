using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameManager gm;
    public void ResetGame()
    {
        Time.timeScale = 1f;
        gm.Lifes = 10;
        SceneManager.LoadSceneAsync(1);
      
    }
}
