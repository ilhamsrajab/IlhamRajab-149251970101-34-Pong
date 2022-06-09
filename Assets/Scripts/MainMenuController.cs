using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
  public void PlayGame()
  {
    SceneManager.LoadScene("Game");

    // muncul author di console log
    Debug.Log("Created by Ilham Syahidatul Rajab - 149251970101-34 | DTS FGA Agate - Game Programming");
  }

  public void OpenAuthor()
  {
    // muncul author di console log
    Debug.Log("Created by Ilham Syahidatul Rajab - 149251970101-34 | DTS FGA Agate - Game Programming");
  }
}
