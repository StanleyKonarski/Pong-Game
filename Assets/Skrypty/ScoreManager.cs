using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text redScoreText, greenScoreText;
    [HideInInspector] public int redScore, greenScore;
    public void IncreasePlayerScore(string name)
    {
        if(name=="RightWall")
        {
            redScore++;
            redScoreText.text = redScore.ToString();
        }
        else
        {
            greenScore++;
            greenScoreText.text = greenScore.ToString();
        }
    }
}
