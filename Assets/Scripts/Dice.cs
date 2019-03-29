using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dice : MonoBehaviour {

	public int DiceNumber;
	public int HolesNumber;
	public int HolesTotal;
	public Text RatHoleText;
	public int ratNumber;

	// Use this for initialization
	void Start () {



		DiceNumber =  Random.Range (1, 7);

		if (DiceNumber == 1) {

			HolesNumber = 4;
			HolesTotal = 4;

		}

		if (DiceNumber == 2) {

			HolesNumber = 7;
			HolesTotal = 7;

		}

		if (DiceNumber == 3) {

			HolesNumber = 12;
			HolesTotal = 12;

		}

		if (DiceNumber == 4) {

			HolesNumber = 15;
			HolesTotal = 15;
		}

		if (DiceNumber == 5) {

			HolesNumber = 18;
			HolesTotal = 18;
		}

		if (DiceNumber == 6) {

			HolesNumber = 20;
			HolesTotal = 20;
		}


		Debug.Log (DiceNumber);


	}
	
	// Update is called once per frame
	void Update () {

		RatHoleText.text = HolesTotal.ToString ();

	}
}
