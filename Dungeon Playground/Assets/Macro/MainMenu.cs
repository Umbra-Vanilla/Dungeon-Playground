using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame()
  {
	  //You can change '1' with scene name; ("SampleScene")
	  SceneManager.LoadSceneAsync(1);
  }

  public void QuitGame()
  {
	  SceneManager.LoadSceneAsync(6);
  }
  public void Options()
	{

	SceneManager.LoadSceneAsync(4);
	}
  public void Back()
	{
		SceneManager.LoadSceneAsync(0);
	}
}
