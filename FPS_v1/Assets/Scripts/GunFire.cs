using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {



	// Update is called once per frame
	void Update () {
		//If Statement: Check if global variable Loaded ammo is greater or equal to 1, then do the following.
		if(GlobalAmmo.LoadedAmmo >= 1){
			if(Input.GetButtonDown("Fire1")){
				AudioSource gunsound = GetComponent<AudioSource>();
				gunsound.Play();
				GetComponent<Animation>().Play ("Gunshot");
				GlobalAmmo.LoadedAmmo -= 1;
			}
		}
	}
}
