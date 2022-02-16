using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {

		//zugalba tekstu kurs panemts no input lauka
	public string teksts;
	//lauks no kurua panemt tekstu
	public GameObject ievadesLauks;
	//tekstsa objekts kur atttelot mainiga teksts saturu
	public GameObject tekstalauks;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstalauks.GetComponent<Text> ().text = "Sveiks " + teksts.ToUpper () + " !";


	}
		

}
