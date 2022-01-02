using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int point;
    public Text ScoreText;

    public void UpdateScore()
    {
        point++;
        ScoreText.text = point.ToString();
    }
}
