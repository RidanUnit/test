using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;

    public void Scene()
    {
        SceneManager.LoadScene(""+sceneName+"");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
