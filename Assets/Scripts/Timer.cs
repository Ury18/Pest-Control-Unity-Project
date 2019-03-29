using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public int minutos=2;
	public float segundos=59;
	public Text TimerText1;
	int segundosToInt;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {

		segundos -= 1*Time.deltaTime;

		if (segundos <= 0) {
			if (minutos > 0) {
				minutos -= 1;
				segundos = 59;
			
			} else {
			
				SceneManager.LoadScene ("looser");  

			}
		}

		segundosToInt = (int)segundos;

		TimerText1.text= "0" + minutos.ToString ();

		if (segundosToInt < 10) {

			TimerText1.text ="0" + minutos.ToString () + ":" + "0" + segundosToInt.ToString ();

		} else {

			TimerText1.text ="0" + minutos.ToString () + ":" + segundosToInt.ToString ();

		}
		
	}
}

