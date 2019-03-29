using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raticate : MonoBehaviour {

	public GameObject PJ;
	public float speed;

	// Use this for initialization
	void Start () {

		PJ = GameObject.Find ("PJ");
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.LookAt ( new Vector3 (PJ.transform.position.x,this.transform.position.y,PJ.transform.position.z));

		//this.gameObject.GetComponent<Transform> ().Translate (new Vector3 (0,0,speed));
		GetComponent<Rigidbody> ().velocity = transform.forward*speed;
	}

	void OnCollisionStay(Collision obj){

		if(obj.gameObject.name =="PJ"){
			PJ.GetComponentInChildren<Shoot> ().vida -= 0.01f;
		}
	}
}
