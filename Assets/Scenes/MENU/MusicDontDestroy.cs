using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicDontDestroy : MonoBehaviour {

	public GameObject AudioCurrent;
	public GameObject AudioPrefab;


	// Use this for initialization
	void Start () {


		AudioCurrent = GameObject.Find ("Musica");

		if(AudioCurrent == null){

			Instantiate (AudioPrefab, this.transform.position, this.transform.rotation);
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
