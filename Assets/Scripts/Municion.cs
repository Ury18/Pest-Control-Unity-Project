using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Municion : MonoBehaviour {

	float tiempo=50;
	bool goTiempo;
	public GameObject PickUpAudio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (tiempo > 0 && goTiempo==true) {
			tiempo = tiempo - 0.1f;
			Debug.Log (tiempo);
		}

		if (tiempo <= 0) {
			goTiempo = false;
			tiempo = 50;
			this.gameObject.GetComponent<BoxCollider>().enabled =true;
			this.gameObject.GetComponent<MeshRenderer>().enabled =true;
		}
	}

	void OnTriggerEnter(Collider obj){
		
		if(obj.gameObject.tag == "Player"){
		Instantiate (PickUpAudio, transform.position, transform.rotation);
		obj.gameObject.GetComponentInChildren<Shoot> ().municionActual = 30;
		obj.gameObject.GetComponentInChildren<Shoot> ().municionEspuma = 5;
		goTiempo = true;
		this.gameObject.GetComponent<BoxCollider>().enabled =false;
		this.gameObject.GetComponent<MeshRenderer>().enabled =false;
		}
		}
}
