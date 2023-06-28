using UnityEngine;
using UnityEngine.UI;

public class ScoreUIUpdater : MonoBehaviour
{
    public Text scoreText; 
    private ScoreScript scoreScript; 

    private void Start()
    {
        
        scoreScript = FindObjectOfType<ScoreScript>();
    }

    private void Update()
    {
        
        scoreText.text = "Score: " + scoreScript.GetScore().ToString();
    }
}
