using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspumaPos : MonoBehaviour {

	public GameObject Location;

	// Use this for initialization
	void Start () {

		Location = GameObject.Find ("DisparoEspumaPos");
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.position = Location.transform.position;

	}
}
