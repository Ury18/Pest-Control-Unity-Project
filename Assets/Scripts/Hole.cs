using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {

	public bool rellenado;
	public GameObject rata;
	bool instanciado;

	float nextRata;

	// Use this for initialization
	void Start () {
		
		nextRata = Time.time + Random.Range (3.0f,4.0f);

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time>=nextRata && rellenado==false){
			Instantiate (rata, transform.position, rata.transform.rotation);	
			nextRata = Time.time + Random.Range (4.0f,5.0f);
		}

	}



}
