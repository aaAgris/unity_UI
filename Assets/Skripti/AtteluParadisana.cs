using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour {

	public GameObject bins;
	public GameObject lacitits;
	public GameObject tante;
	public GameObject masina;

	public void binaAttelosana(bool vertiba){
		bins.SetActive (vertiba);
	}

	public void lacisaAttelosana(bool vertiba){
		lacitits.SetActive (vertiba);
	}

	public void tantesAttelosana(bool vertiba){
		tante.SetActive (vertiba);
	}

	public void masinaAttelosana(bool vertiba){
		masina.SetActive (vertiba);
	}

	public void paKreisiBins(){
		bins.transform.localScale = new Vector2 (1, 1);
	}

	public void paLabiBins(){
		bins.transform.localScale = new Vector2 (-1, 1);
	}





}
