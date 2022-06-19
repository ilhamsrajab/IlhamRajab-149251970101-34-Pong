using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUExtendController : MonoBehaviour
{
  public Collider2D ball;
  public PaddleController paddleKanan;
  public PaddleController paddleKiri;
  public bool isRight;
  public float effect;
  public PowerUpManager manager;
  public int Duration;
  private float timerExtend;
  private bool isExtend;

  private void Start()
  {
    timerExtend = 0;
  }

  private void Update()
  {
    timerExtend += Time.deltaTime;
    Debug.Log(timerExtend);

    if (timerExtend > Duration)
    {
      DeactivatePUExtend(gameObject);
      timerExtend -= Duration;

      isExtend = false;
    }
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision == ball)
    {
      if (isRight)
      {
        paddleKanan.GetComponent<PaddleController>().transform.localScale *= new Vector2(1, effect);
        // paddleKanan.GetComponent<PaddleController>().ActivatePUExtend(effect);
        Debug.Log("Power Up Extend Paddle Kanan");
        isExtend = true;
        Debug.Log(isExtend);

        manager.RemovePowerUp(gameObject);

      }
      else
      {
        paddleKiri.GetComponent<PaddleController>().transform.localScale *= new Vector2(1, effect);
        // paddleKiri.GetComponent<PaddleController>().ActivatePUExtend(effect);
        Debug.Log("Power Up Extend Paddle Kiri");
        isExtend = true;
        Debug.Log(isExtend);

        manager.RemovePowerUp(gameObject);
      }
    }
  }
  private void DeactivatePUExtend(GameObject paddle)
  {
    paddle.GetComponent<PaddleController>().transform.localScale = new Vector2(.2f, 2);
    Debug.Log("Power Up Extend Paddle Sudah Habis");

    isExtend = false;
  }

}
