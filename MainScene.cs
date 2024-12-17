using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadSceneAsync(1); //loads main scene 
    }
    public void options()
    {
        SceneManager.LoadSceneAsync(2);  //loads options scene
    }
    public void quit() //quits game
    {
        Application.Quit();
    }
}
