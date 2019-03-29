using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RaticateTry : MonoBehaviour {

	public float distanceAway;
	public Transform thisObject;
	public Transform target;
	private NavMeshAgent navComponent;

	// Use this for initialization
	void Start () {

		target = GameObject.FindGameObjectWithTag ("Player").transform;
		navComponent = this.gameObject.GetComponent<NavMeshAgent> ();
		GameObject.Find ("Dice").GetComponent<Dice> ().ratNumber += 1;
		Debug.Log (GameObject.Find ("Dice").GetComponent<Dice> ().ratNumber);
	}

	// Update is called once per frame
	void Update () {

		float dist = Vector3.Distance (target.position, thisObject.position);

		if (target) {
			navComponent.SetDestination (target.position);
			transform.LookAt ( new Vector3 (target.transform.position.x,this.transform.position.y,target.transform.position.z));
		} else {
			if (target == null) {
				target = this.gameObject.GetComponent<Transform> ();
			} else {
				target = GameObject.FindGameObjectWithTag ("Player").transform;
			}
		}
		if (dist < 1.50f) {
			Debug.Log ("hola");
			target.GetComponentInChildren<Shoot> ().vida -= 0.001f;

		}
			
	}
		
}
