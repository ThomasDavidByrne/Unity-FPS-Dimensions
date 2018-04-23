using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public int EnemyHealth = 10;

	//Function called DeductedPoints invoked in HandGunDamage script which refrences DamageAmount.
	void DeductPoints (int DamageAmount) {

		//Each time this function is called it makes the enemy health equal and take off the damange amount.
		EnemyHealth -= DamageAmount;
	}

	void Update () {
		if (EnemyHealth <= 0) {
			Destroy(gameObject);
		}
	}﻿
}
