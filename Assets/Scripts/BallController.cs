using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class BallController : MonoBehaviour
// {
//   // Start is called before the first frame update
//   void Start()
//   {

//   }

//   // Update is called once per frame
//   void Update()
//   {
//     Vector3 pos = transform.position;

//     // menggunakan translate
//     transform.Translate(new Vector3(1f, 1f, 0) * Time.deltaTime);

//     // menggunakan position
//     // transform.position = transform.position + new Vector3(0.1f, 0, 0) * Time.deltaTime;
//   }
// }

// agar edit speed lebih mudah di editor dengan menggunakan public variabel
public class BallController : MonoBehaviour
{
  public Vector2 speed;
  public Vector2 resetPosition;
  private Rigidbody2D rig;
  private void Start()
  {
    rig = GetComponent<Rigidbody2D>();
    rig.velocity = speed;
  }

  public void ResetBall()
  {
    transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
  }
}