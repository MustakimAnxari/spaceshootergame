using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text gameText;

    private void Start()
    {
        string username = PlayerPrefs.GetString("Username", ""); 
        int score = ScoreScript.score; 

        string gameOverMessage = $"{username} scored: {score}"; 

        gameText.text = gameOverMessage; 
    }
}
