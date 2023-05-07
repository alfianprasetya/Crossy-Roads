using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
   public void Restart()
  {
    SceneManager.LoadScene("Play");
  }

  public void Menu()
  {
    SceneManager.LoadScene("Menu");
  }
}
