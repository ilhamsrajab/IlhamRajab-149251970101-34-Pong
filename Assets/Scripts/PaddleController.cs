using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
  public int speed;
  public KeyCode upKey;
  public KeyCode downKey;
  private Rigidbody2D rig;

  private void Start()
  {
    rig = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    // get input
    Vector3 movement = GetInput();

    // pindah object
    MoveObject(GetInput());
    // MoveObject(movement); //alternate
  }
  private Vector2 GetInput()
  {
    // ke atas
    if (Input.GetKey(upKey))
    {
      return Vector2.up * speed;
    }
    // ke bawah
    else if (Input.GetKey(downKey))
    {
      return Vector2.down * speed;
    }
    return Vector2.zero;
  }

  private void MoveObject(Vector2 movement)
  {
    // transform.Translate(movement * Time.deltaTime);
    rig.velocity = movement;
  }
}
