//Main game management code
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameManager : MonoBehaviour
{   
    public GameObject Player;
    public Text FinalScoreText;
    public Text ScoreText;
    public ScoreCount ScoreCount;
    public GameObject DeathPanel;
    bool isAlive = true;
    //reloads current scene from the death screen panel
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Loads the main menu screen back
    public void Exit() {
        SceneManager.LoadScene(0);
    }
    //Quits the game completely
    public void QuitGame() {
        Application.Quit();
    }

    //Kills the player, initially stopping counting the score, then disabling movement control,
    //hands over the death to FreezePlayer() ...
    public void Die() {
        if (isAlive)
        {
            isAlive = false;
            ScoreCount.enabled = false;
            Player.GetComponent<Movement>().enabled = false;
            StartCoroutine(FreezePlayer());
        }
    }
    //...which in its turn freeze the cube into place for effect and hands over to ContinueDeath() ...

    IEnumerator FreezePlayer() {
        yield return new WaitForSeconds(2);
        Rigidbody PlayerRb = Player.GetComponent<Rigidbody>();
        PlayerRb.constraints = RigidbodyConstraints.FreezeAll;
        ContinueDeath();    
    }
    //... that in its turn starts the animation for the death panel and shows the player their final score.
    void ContinueDeath() {
        ScoreText.gameObject.SetActive(false);
        DeathPanel.SetActive(true);
        FinalScoreText.text = ScoreText.text;
    }

}
