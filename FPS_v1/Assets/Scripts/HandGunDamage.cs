using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour {

	public int DamageAmount = 5;
	public float TargetDistance;
	public float AllowedRange = 20.0f;


	void Update () {


		if(GlobalAmmo.LoadedAmmo >= 1){
			
			//If Statement: To check if fire button is being held.
			if(Input.GetButtonDown("Fire1")) {

				//Means of determining how far an object is away from the player.
				RaycastHit Shot;

				//If statement: Raycast will send out a 'shot' to see how far away any object, of the forward direction is.
				if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Shot)) {

					//How far we are away as determined by the raycast.
					TargetDistance = Shot.distance;

					//If statement: to check if our target distance is less than what we allow, perform the action below.
					if (TargetDistance < AllowedRange) {

						//Invoke another script which is pre set on enemy object.
						Shot.transform.SendMessage ("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
					}
				}
			}
		}
	}
}
