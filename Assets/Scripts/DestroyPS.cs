using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPS : MonoBehaviour {

	public GameObject Location;

	// Use this for initialization
	void Start () {

		Location = GameObject.Find ("DisparoPos");

	}
	
	// Update is called once per frame
	void Update () {


		this.transform.position = Location.transform.position;
		
	}

	void DestroyPSshoot(){
		Destroy (this.gameObject);
	}
}
