using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpSMG : MonoBehaviour {

	public float TheDistance = PlayerCasting.DistanceFromTarget;
	public GameObject TextDisplay;

	//GameObject(Gun) currently being used in the game.
	public GameObject FakeGun;
	//GameObject(Gun) to display as a result of picking up the desired gun.
	public GameObject RealGun;
	public GameObject GunOnBox;
	//public GameObject AmmoDisplay;
	//public AudioSource PickUpAudio;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
		if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 2 ) {
				StartCoroutine(TakeSMG());
			}
		}
	}
	void OnMouseOver () {
		if (TheDistance <= 0.05 ) {
			TextDisplay.GetComponent<Text>().text = "Take SMG";
		}
	}

	void OnMouseExit () {
		TextDisplay.GetComponent<Text>().text = "";
	}
		
	IEnumerator TakeSMG () {
		//PickUpAudio.Play();
		transform.position = new Vector3(0, -1000, 0);
		FakeGun.SetActive(false);
		RealGun.SetActive(true);
		GunOnBox.SetActive(false);
		//AmmoDisplay.SetActive(true);
		yield return new WaitForSeconds(0.1f);
	}﻿
}
