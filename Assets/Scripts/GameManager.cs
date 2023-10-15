using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;

    public Text ScoreText;

    [Header ("Numbers")]
    [Range(0f, 1f)]
    public float myLuckyNumber;



    void Start()
    {
        ScoreText.text = score.ToString();
    }
    
    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}


