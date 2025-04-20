using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuing : MonoBehaviour
{
    public void LoadMaze()
    {
        SceneManager.LoadScene("MazeLevel");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void LoadWinScreen()
    {
        SceneManager.LoadScene("WinScreen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
