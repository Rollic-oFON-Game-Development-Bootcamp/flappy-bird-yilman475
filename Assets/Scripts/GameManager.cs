using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int point;
    public Text ScoreText;
    public PlayerController PlayerController;

    public void UpdateScore()
    {
        point++;
        ScoreText.text = point.ToString();
    }

    public void GameOver()
    {
        //
    }

    public void StartGame()
    {
        //
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        /* Scene scene = SceneManager.GetActiveScene();
         SceneManager.LoadScene(scene.name);*/
    }
}
