using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void EndPlay()
    {
        SceneManager.LoadScene("GameExit");
    }
    
    public void GoToHighscores()
    {
        SceneManager.LoadScene("Highscores");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        // Only works in Windows build
        Application.Quit();
    }
}
