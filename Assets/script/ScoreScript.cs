using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    private int score;

    private void Start()
    {
        score = 0; 
    }

    public void IncreaseScore(int incrementAmount)
    {
        score += incrementAmount;
    }

    public int GetScore()
    {
        return score; 
    }
}
