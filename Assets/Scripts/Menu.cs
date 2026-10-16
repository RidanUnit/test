using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Game()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void StartScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void Exit()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Game();
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            Exit();
        }
    }

}
