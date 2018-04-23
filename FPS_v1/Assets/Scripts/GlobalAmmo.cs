using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour {

		//Static ammo number.
		public static int CurrentAmmo;
		//Internal equivalent of that CurrentAmmo above.	
		public int InternalAmmo;
		//Text box created in game.
		public GameObject AmmoDisplay;

		public static int LoadedAmmo;
		public int InternalLoaded;
		public GameObject LoadedDisplay;

		void Update()
		{
			//Making internal ammo number = to static ammo number.	
			InternalAmmo = CurrentAmmo;
			
			InternalLoaded = LoadedAmmo;

			//Get component, which is of type text within the text box created + InternalAmmo.
			AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;

			LoadedDisplay.GetComponent<Text>().text = "" + LoadedAmmo;


		}
}

