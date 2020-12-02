//Shows distance from start of the game in integer units
using UnityEngine;
using UnityEngine.UI;
public class ScoreCount : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    void Update() {
        ScoreText.text = Player.position.z.ToString("0");
    }
}
