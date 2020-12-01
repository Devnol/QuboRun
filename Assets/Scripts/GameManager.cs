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
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit() {
        SceneManager.LoadScene(0);
    }
    public void Die() {
        if (isAlive)
        {
            isAlive = false;
            ScoreCount.enabled = false;
            Player.GetComponent<Movement>().enabled = false;
            StartCoroutine(FreezePlayer());
        }
    }

    public void QuitGame() {
        Application.Quit();
    }

    void ContinueDeath() {
        ScoreText.gameObject.SetActive(false);
        DeathPanel.SetActive(true);
        FinalScoreText.text = ScoreText.text;
    }

    IEnumerator FreezePlayer() {
        yield return new WaitForSeconds(2);
        Rigidbody PlayerRb = Player.GetComponent<Rigidbody>();
        PlayerRb.constraints = RigidbodyConstraints.FreezeAll;
        ContinueDeath();    
    }

    
}
