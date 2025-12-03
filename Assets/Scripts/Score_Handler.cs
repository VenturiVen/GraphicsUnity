using UnityEngine;

public class Score_Handler : MonoBehaviour
{

    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    public void scoreIncrease()
    {
        score++;
    }

    public int getScore()
    {
        return score;   
    }

}
