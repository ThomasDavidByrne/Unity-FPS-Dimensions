using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {

	public void PlaySound()
	{
		AudioSource audioSource = GetComponent<AudioSource>();
		audioSource.Play();
	}

}
