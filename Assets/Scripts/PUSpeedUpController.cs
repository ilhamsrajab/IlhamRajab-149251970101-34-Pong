using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
  public Collider2D ball;
  public float magnitude;
  public PowerUpManager manager;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision == ball)
    {
      ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
      Debug.Log("Power Up Speed Up Ball");

      manager.RemovePowerUp(gameObject);
    }
  }
}
