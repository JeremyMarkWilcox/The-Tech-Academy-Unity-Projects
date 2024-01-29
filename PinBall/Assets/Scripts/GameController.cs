using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public Animator leftPaddleAnimator;
    public Animator rightPaddleAnimator;
    public TextMeshProUGUI scoreText;

    private int score = 0;
    private bool hasWon = false;

    private void Update()
    {
        if (!hasWon)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                leftPaddleAnimator.ResetTrigger("Pressed");
                leftPaddleAnimator.SetTrigger("Pressed");
            }

            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                rightPaddleAnimator.ResetTrigger("Pressed");
                rightPaddleAnimator.SetTrigger("Pressed");
            }

            if (score >= 100)
            {
                WinGame();
            }
        }
    }

    public void AddScore()
    {
        score += 25;
        scoreText.text = "SCORE: " + score;
    }

    private void WinGame()
    {
        if (!hasWon)
        {
            hasWon = true;
            scoreText.text = "<color=red><b>Congratulations! You've won the game!</b></color>";
            StartCoroutine(QuitGameAfterDelay(3f));
        }
    }

    private IEnumerator QuitGameAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        QuitGame();
    }

    private void QuitGame()
    {
        // Quit the application
        Debug.Log("Quitting game...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
}
