using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene("Game");

        Debug.Log("Game has been restarted!");
    }

    public void QuitGame()
    {
        Debug.Log("Game has been quit!");

        Application.Quit();
    }

}
