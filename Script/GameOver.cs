using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	public TextMeshProUGUI pointsText;
    // Start is called before the first frame update
    void Start()
    {
		int receivedPoints = ItemCollector.coins;
		pointsText.text = receivedPoints.ToString() + " COINS";
		ItemCollector.coins = 0;
        
    }
	
	public void Menu()
	{
		SceneManager.LoadScene("Start-new");
	}
	
	public void Retry()
	{
		SceneManager.LoadScene("Satu");
	}
}
