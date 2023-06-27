using UnityEngine;
using UnityEngine.UI;

public class ScoreUIUpdater : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text component
    private ScoreScript scoreScript; // Reference to the ScoreScript

    private void Start()
    {
        // Find the ScoreScript component in the scene
        scoreScript = FindObjectOfType<ScoreScript>();
    }

    private void Update()
    {
        // Update the UI text with the current score
        scoreText.text = "Score: " + scoreScript.GetScore().ToString();
    }
}
