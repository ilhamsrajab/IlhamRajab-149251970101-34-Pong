using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUExtendController : MonoBehaviour
{
  public Collider2D ball;
  public BallController ballController;
  public PowerUpManager manager;
  public float effect;
  public int Duration;
  public float resetScaleX;
  public float resetScaleY;
  private float timerExtend;
  private bool isExtend;
  private GameObject namaPaddle;

  private void Start()
  {
    isExtend = true;
  }

  private void Update()
  {
    if (isExtend == true)
    {
      if (timerExtend >= 0)
      {
        timerExtend -= Time.deltaTime;
      }
      else
      {
        DeactivePUExtend();
        timerExtend = 0;
      }
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision == ball)
    {
      namaPaddle = GameObject.Find(ballController.sentuhPaddle);

      namaPaddle.GetComponent<PaddleController>().ActivatePUExtend(effect);

      // Debug.Log("Power Up Extend " + namaPaddle);

      isExtend = true;

      manager.RemovePowerUp(gameObject);
    }
  }

  private void DeactivePUExtend()
  {
    namaPaddle = GameObject.Find(ballController.sentuhPaddle);

    namaPaddle.GetComponent<PaddleController>().transform.localScale = new Vector2(resetScaleX, resetScaleY);
    // Debug.Log("Power Up Extend " + namaPaddle + " Habis");

    isExtend = false;
  }
}
