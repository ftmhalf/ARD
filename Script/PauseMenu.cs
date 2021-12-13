using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	[SerializeField] GameObject pauseMenu;
	[SerializeField] private AudioSource buttonSoundEffect;
	
	public void Pause()
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 0f;
		buttonSoundEffect.Play();
	}
	
	public void Resume()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
		buttonSoundEffect.Play();
	}
	
	public void Home()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("SelectLevel");
		buttonSoundEffect.Play();
	}
}
