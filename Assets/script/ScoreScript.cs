using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    private int score;

    private void Start()
    {
        score = 0; // Initialize the score to zero
    }

    public void IncreaseScore(int incrementAmount)
    {
        score += incrementAmount; // Increase the score by the specified amount
    }

    public int GetScore()
    {
        return score; // Return the current score
    }
}
