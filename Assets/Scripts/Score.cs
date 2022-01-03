using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text scoreText;
    private void Awake()
    {
        scoreText = transform.Find("scoreText").GetComponent<Text>();
    }
}
