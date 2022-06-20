using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpPaddleController : MonoBehaviour
{
  public Collider2D ball;
  public BallController ballController;
  public PowerUpManager manager;
  public float effect;
  public int Duration;
  private float timerSpeedUp;
  private bool isSpeedUp;
  private GameObject namaPaddle;

  private void Start()
  {
    isSpeedUp = false;
  }

  private void Update()
  {
    if (isSpeedUp == true)
    {
      if (timerSpeedUp >= 0)
      {
        timerSpeedUp -= Time.deltaTime;
      }
      else
      {
        DeactivePUSpeedUp();
        timerSpeedUp = 0;
      }
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision == ball)
    {
      namaPaddle = GameObject.Find(ballController.PaddleName);

      namaPaddle.GetComponent<PaddleController>().ActivatePUSpeedUp(effect);

      Debug.Log("Power Up Speed Up " + namaPaddle);
      timerSpeedUp = 0;

      isSpeedUp = true;
      Debug.Log("is SpeedUp " + isSpeedUp);

      manager.RemovePowerUp(gameObject);
    }
  }

  private void DeactivePUSpeedUp()
  {
    namaPaddle = GameObject.Find(ballController.PaddleName);

    namaPaddle.GetComponent<PaddleController>().DeactivatePUSpeedUp(effect);
    Debug.Log("Power Up Speed Up " + namaPaddle + " Habis");

    isSpeedUp = false;
  }
}
