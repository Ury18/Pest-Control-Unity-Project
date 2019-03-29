using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shoot : MonoBehaviour {

	public GameObject relleno;

	public int municionActual=30;
	public Text MunicionText;

	public int municionEspuma;
	public Text MunicionEspumaText;

	public bool EnMunicion;

	float distancia=1.5f;

	public GameObject DisparoPS;
	public GameObject DisparoPos;

	public GameObject EspumaPS;
	public GameObject EspumaPos;

	public GameObject DustPS;

	public GameObject sangrePS;

	public float vida=1;
	public Image vidaImg;

	public GameObject dice;

	public GameObject ShootAudio;
	public GameObject FoamAudio;
	public GameObject RatDeadAudio;
	public GameObject GoreAudio;

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {

		MunicionText.text = municionActual.ToString ();
		MunicionEspumaText.text = municionEspuma.ToString ();
		vidaImg.fillAmount = vida;

		Vector3 dir;
		RaycastHit hit;
		Ray forwardRay = new Ray (Camera.main.transform.position, transform.forward);
		Debug.DrawRay (Camera.main.transform.position, transform.forward, Color.red);

		if (Input.GetMouseButtonDown (0)) {
			if (municionActual > 0) {
				Instantiate (DisparoPS, DisparoPos.transform.position, DisparoPos.transform.rotation);
				Instantiate (ShootAudio, transform.position, transform.rotation);
				municionActual = municionActual - 1;
				Debug.Log (municionActual);
				if (Physics.Raycast (forwardRay, out hit, 100000000, ~LayerMask.GetMask ("Player"))) {
					if (hit.collider.tag == "rata") {
						Instantiate (sangrePS, hit.collider.transform.position, Quaternion.identity);
						Instantiate (RatDeadAudio, hit.collider.transform.position, hit.collider.transform.rotation);
						Instantiate (GoreAudio, hit.collider.transform.position, hit.collider.transform.rotation);
						dice.GetComponent<Dice> ().ratNumber -= 1;
						Destroy (hit.collider.gameObject);
					} else {
						Instantiate (DustPS, hit.point, Quaternion.identity);
					}
				}

			}
		}

		if (Input.GetMouseButtonDown (1)) {
			if(municionEspuma>0){
				Instantiate (EspumaPS, EspumaPos.transform.position, EspumaPos.transform.rotation);
				Instantiate (FoamAudio, transform.position, transform.rotation);
				municionEspuma -= 1;
			if (Physics.Raycast (forwardRay, out hit, 100000000)) {
				if (hit.collider.tag == "hole" && hit.collider.GetComponent<Hole>().rellenado==false) {
					Debug.Log ("rellenao");
					Instantiate (relleno, hit.collider.transform.position, hit.collider.transform.rotation);
					hit.collider.GetComponent<Hole> ().rellenado = true;
					dice.GetComponent<Dice> ().HolesTotal -= 1;
				}
			}
		}
			
	}

		if (vida <= 0) {
			SceneManager.LoadScene ("looser");
		}

		if (dice.GetComponent<Dice> ().HolesTotal <= 0 && dice.GetComponent<Dice>().ratNumber<=0) {
			SceneManager.LoadScene ("win");
		}

}
}


