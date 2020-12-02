using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    //Loads the actual game scene
    public void StartGame(){
        SceneManager.LoadScene(1);
    }

    //Completely quits the application
    public void QuitGame() {
        Application.Quit();
    }

}
