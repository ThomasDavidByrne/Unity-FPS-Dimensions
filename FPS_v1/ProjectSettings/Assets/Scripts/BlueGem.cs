using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGem : MonoBehaviour {

	public int RotateSpeed;
	public AudioSource CollectSound;
	public GameObject TheGem;
	public GameObject pickupEffect;
	public float multiplier;


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
		bigUp(player);
	}
	void bigUp(Collider player)
	{
		player.transform.localScale *= multiplier;
	}
}
