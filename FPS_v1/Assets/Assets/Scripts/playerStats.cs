using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerStats : MonoBehaviour {
	public float health = 100f;
	public float lives = 1f;
	public float score = 0f;
	public Text scoreText;
	public Text healthText;
	public Text livesText;
	void Update()
	{
		UpdateScore ();
		UpdateHealth ();
		UpdateLives ();

	}

	void UpdateScore()
	{
		scoreText.text = "Score = " + score.ToString ();
	}
	void UpdateHealth()
	{
		healthText.text = "Health = " + health.ToString ();

	}
	void UpdateLives()
	{
		livesText.text = "Lives =" + lives.ToString ();
	}
}
