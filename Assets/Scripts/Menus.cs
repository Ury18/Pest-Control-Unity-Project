using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



	}



	public void Play(){


		SceneManager.LoadScene ("scena1");
		GameObject AudioMenus = GameObject.Find ("Musica");
		Destroy (AudioMenus);

	}


	public void Controls(){


		SceneManager.LoadScene ("controls");

	}


	public void Credits(){


		SceneManager.LoadScene ("credits");

	}


	public void Quit(){


		Application.Quit ();

	}


	public void Back(){

		SceneManager.LoadScene ("menu");


	}
}
