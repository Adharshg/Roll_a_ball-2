﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_menu : MonoBehaviour {

	public static bool Gameispaused = false;

	public GameObject pauseMenuUI;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (Gameispaused){
				Resume();
			}
			else{
				Pause();
			}
		}
	}

	public void Resume(){
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		Gameispaused = false;
	}

	void Pause(){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		Gameispaused = true;
	}

	public void LoadMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
