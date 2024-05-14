using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;

    public void IncreaseScore()
    {
        score++;
        Debug.Log("" + score);
    }

    public void GameOver()
    {
        Debug.Log("Game OVER");
    }
}
