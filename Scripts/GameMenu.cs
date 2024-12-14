using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int SceneBuildIndexx = SceneManager.GetActiveScene().buildIndex;
    public void loadNextLevel()
        { 
    SceneManager.LoadScene(SceneBuildIndexx+1);
        }
        public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
