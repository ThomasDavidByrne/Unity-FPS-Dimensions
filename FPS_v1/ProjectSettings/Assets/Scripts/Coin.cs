using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	public int RotateSpeed;
	public AudioSource CollectSound;
	public GameObject TheGem;
	public GameObject pickupEffect;

	void Update () {
		transform.Rotate (0, RotateSpeed, 0, Space.World );

	}
	void OnTriggerEnter( Collider other ){
		if (other.CompareTag("Player"))
		{
			Pickup(other);
		}
	}
	void Pickup(Collider player)
	{
		CollectSound.Play ();
		TheGem.SetActive (false);
		GameObject effect = Instantiate (pickupEffect, transform.position, transform.rotation);
		Destroy (effect, 1.8f);
		ScorePlus (player);
	}
	void ScorePlus (Collider Player)
	{
		playerStats stats = Player.GetComponent<playerStats> ();
		stats.score++;
	}
}
