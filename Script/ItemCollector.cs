using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public static int coins=0;
    [SerializeField] Text coinsText;
	[SerializeField] private AudioSource collectSoundEffect;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins+=100;
            coinsText.text = "Coins: " + coins;
			collectSoundEffect.Play();
        }
    }
}
