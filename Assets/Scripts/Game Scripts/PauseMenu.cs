using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUi;

	public GameObject l;
	public GameObject r;

    // Update is called once per frame
    void Update()
    {
        
    }

	public void GamePause()
	{

	}

	public void Resume()
	{
		pauseMenuUi.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		l.SetActive(true);
		r.SetActive(true);
	}

	public void Pause()
	{
		pauseMenuUi.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		l.SetActive(false);
		r.SetActive(false);
	}

	public void QuitGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
}
