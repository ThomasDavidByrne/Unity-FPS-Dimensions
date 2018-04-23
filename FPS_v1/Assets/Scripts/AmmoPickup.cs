using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour 
{
	public AudioSource AmmoSound;

	void OnTriggerEnter(Collider other)
	{
		
		AmmoSound.Play();

		//If Statement: Check to see if the global variable Loaded variable is equal to 0.
		if (GlobalAmmo.LoadedAmmo == 0) {
			GlobalAmmo.LoadedAmmo += 10;
			this.gameObject.SetActive (false);
		} else {
			//Increase whatever the value of our currentAmmo is in the global ammo script by 10.
			GlobalAmmo.CurrentAmmo += 10;

			//Disable the game object.
			this.gameObject.SetActive (false);
		}
	}
}
