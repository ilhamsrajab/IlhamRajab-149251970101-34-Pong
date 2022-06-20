using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
  public Vector2 speed;
  public Vector2 resetPosition;
  public string lastCollision;
  public string PaddleName;
  private Rigidbody2D rig;

  private void Start()
  {
    rig = GetComponent<Rigidbody2D>();
    rig.velocity = speed;
  }

  public void ResetBall()
  {
    transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
    rig.velocity = speed;
  }

  public void ActivatePUSpeedUp(float magnitude)
  {
    rig.velocity *= magnitude;
    Debug.Log(speed);
  }

  private void OnCollisionEnter2D(Collision2D collisionInfo)
  {
    lastCollision = collisionInfo.collider.tag;
    PaddleName = collisionInfo.collider.name;

    if (lastCollision == "PaddleKanan")
    {
      // Debug.Log(PaddleName + " menyentuh bola");
    }
  }
}