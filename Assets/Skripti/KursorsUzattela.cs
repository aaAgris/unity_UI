﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursorsUzattela : MonoBehaviour {
	public AudioSource skanasAvots;
	public AudioClip skanaKoAtskanot;

	public void uzbiditsUzAttela(){
		skanasAvots.PlayOneShot(skanaKoAtskanot);
	}

	public void nobiditsNoAttela(){
		skanasAvots.Stop ();
	}

}
