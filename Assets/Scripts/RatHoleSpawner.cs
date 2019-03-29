using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatHoleSpawner : MonoBehaviour {

	public GameObject[] RatHolesLocations;
	public GameObject Dice;
	public GameObject RatHole;
	public int[] NumeroRatholes; 
	int j;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {



		if(Dice.GetComponent<Dice>().HolesNumber > 0){


			j =  Random.Range (0, NumeroRatholes.Length); 




			if (RatHolesLocations[j] == null) { 



			} else {


				Instantiate (RatHole,RatHolesLocations[j].transform.position,RatHolesLocations[j].transform.rotation);
				Dice.GetComponent<Dice> ().HolesNumber -= 1;
				RatHolesLocations[j] = null;
	
			}


		}





	}
}
