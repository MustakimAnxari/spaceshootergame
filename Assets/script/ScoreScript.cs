using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public static int score;

    public void Start()
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
