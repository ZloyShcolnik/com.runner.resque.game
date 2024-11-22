using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private float score;
    private Text scoreText;

    private void Awake()
    {
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        score += 3 * Time.deltaTime;
        scoreText.text = $"{Mathf.RoundToInt(score)}";
    }
}
