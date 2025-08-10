using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Playing the game");
        SceneManager.LoadSceneAsync(1);
    }

    public void ExitGame()
    {

        Debug.Log("Exiting the game...");
        SceneManager.LoadSceneAsync(2);



    }
}
