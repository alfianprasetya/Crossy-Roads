using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject creditsCanvas;
    [SerializeField] GameObject optionsCanvas;

  private void Start() {
    // Screen.orientation = ScreenOrientation.Portrait;
    // Screen.SetResolution(1080, 1920, true);
  }
  public void Play()
  {
    SceneManager.LoadScene("Play");
  }

  public void Quit()
  {
    Application.Quit();
  }
}
