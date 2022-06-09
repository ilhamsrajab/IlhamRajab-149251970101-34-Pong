using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
  public int rightScore;
  public int leftScore;
  public int maxScore;
  public BallController ball;

  public void AddRightScore(int increment)
  {
    ball.ResetBall();

    rightScore += increment;

    // debug jumlah skor kanan
    Debug.Log("score kanan = " + rightScore);
    if (rightScore >= maxScore)
    {
      // debug kanan menang
      Debug.Log("Kanan menang");
      GameOver();
    }
  }
  public void AddLeftScore(int increment)
  {
    ball.ResetBall();

    leftScore += increment;

    // debug jumlah skor kiri
    Debug.Log("score kiri = " + leftScore);

    if (leftScore >= maxScore)
    {
      // debug kanan menang
      Debug.Log("Kiri menang");
      GameOver();
    }
  }
  public void GameOver()
  {
    SceneManager.LoadScene("MainMenu");
  }
}
