using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public void updateScore(float score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
