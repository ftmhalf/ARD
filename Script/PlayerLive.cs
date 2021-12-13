using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLive : MonoBehaviour
{
	public int maxHealth = 5;
	public int currentHealth;
	public HealthBar healthBar;
    private Rigidbody2D rb;
    private Animator anim;
	[SerializeField] private AudioSource ranjauSoundEffect;
	[SerializeField] private AudioSource deathSoundEffect;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            TakeDamage(1);
			ranjauSoundEffect.Play();
        }
		if (collision.gameObject.CompareTag("Water"))
        {
            Die();
        }
		
    }
	
	private void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
		if(currentHealth<=0)
		{
			Die();
		}
	}
	

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
		deathSoundEffect.Play();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene("GameOver");
    }
}
