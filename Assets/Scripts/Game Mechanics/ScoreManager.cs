using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    
    private int BluePlayerScore = 0;
    private int RedPlayerScore = 0;

    public Text BlueScoreText;
    public Text RedScoreText;
    public int scoreToReach = 4;

    public void BlueScore()
    {
        BluePlayerScore++;
        BlueScoreText.text = BluePlayerScore.ToString();
        CheckScore();
    }
    
    public void RedScore()
    {
        RedPlayerScore++;
        RedScoreText.text = RedPlayerScore.ToString();
        CheckScore();
    }

    private void CheckScore()
    {
        if (BluePlayerScore == scoreToReach || RedPlayerScore == scoreToReach){
            SceneManager.LoadScene(2);
        }
    }
}
