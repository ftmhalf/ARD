using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	
	[SerializeField] private AudioSource buttonSoundEffect;
    public void PlayGame()
    {
        SceneManager.LoadScene("SelectLevel");
		buttonSoundEffect.Play();
    }

    public void CreditsGame()
    {
        SceneManager.LoadScene("Credits");
		buttonSoundEffect.Play();
    }
	
	public void Menu()
	{
		SceneManager.LoadScene("Start-new");
		buttonSoundEffect.Play();
	}

	public void Retry()
	{
		SceneManager.LoadScene("Satu");
		buttonSoundEffect.Play();
	}
	
	public void Options()
	{
		SceneManager.LoadScene("Options");
		buttonSoundEffect.Play();
	}


    public void QuitGame ()
    {
        Debug.Log("quit");
		buttonSoundEffect.Play();
        Application.Quit();
    }
}
