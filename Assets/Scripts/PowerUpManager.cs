using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
  public Transform spawnArea;
  public int spawnInterval;
  public int removeSpawnInterval;
  public int maxPowerUpAmount;
  public Vector2 powerUpAreaMin;
  public Vector2 powerUpAreaMax;
  public List<GameObject> powerUpTemplateList;
  private float timer;
  private float timerHapus;
  private List<GameObject> powerUpList;


  // Start is called before the first frame update
  private void Start()
  {
    powerUpList = new List<GameObject>();
    timer = 0;
    timerHapus = 0;
  }

  private void Update()
  {
    timer += Time.deltaTime;
    timerHapus += Time.deltaTime;

    if (timer > spawnInterval)
    {
      GenerateRandomPowerUp();
      timer -= spawnInterval;
    }

    if (timerHapus > removeSpawnInterval && powerUpList.Count >= maxPowerUpAmount)
    {
      RemovePowerUp(powerUpList[0]);
      timerHapus -= removeSpawnInterval;
    }
  }

  public void GenerateRandomPowerUp()
  {
    GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));
  }

  public void GenerateRandomPowerUp(Vector2 position)
  {
    if (powerUpList.Count >= maxPowerUpAmount)
    {
      return;
    }

    if (position.x < powerUpAreaMin.x || position.x > powerUpAreaMax.x || position.y < powerUpAreaMin.y || position.y > powerUpAreaMax.y)
    {
      return;
    }

    int randomIndex = Random.Range(0, powerUpTemplateList.Count);

    GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
    powerUp.SetActive(true);

    powerUpList.Add(powerUp);
  }

  public void RemovePowerUp(GameObject powerUp)
  {
    powerUpList.Remove(powerUp);
    Destroy(powerUp);
  }

  public void RemoveAllPowerUp()
  {
    while (powerUpList.Count > 0)
    {
      RemovePowerUp(powerUpList[0]);
    }
  }
}
