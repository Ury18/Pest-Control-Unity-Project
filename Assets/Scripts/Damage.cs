using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	bool damaged;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider obj){

		if (obj.gameObject.tag == "Player") {
			if (damaged == false) {
				obj.gameObject.GetComponentInChildren<Shoot> ().vida -= 0.2f;
				damaged = true;
			}
		}
	}

}
