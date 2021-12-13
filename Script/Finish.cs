using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
	[SerializeField] private AudioSource finishSoundEffect;
	
    private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.name == "Agent")
		{
			finishSoundEffect.Play();
			Invoke("CompleteLevel", 2f);
		}
	}
	
	private void CompleteLevel()
	{
		SceneManager.LoadScene("WinScene");
	}
}
