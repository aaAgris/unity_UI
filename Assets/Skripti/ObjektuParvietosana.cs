using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//interfeiss lai nodrosinatu peles funkcijas
using UnityEngine.EventSystems;


public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler,IDragHandler,IEndDragHandler {

	private RectTransform transformacijasLogs;
	public Canvas kanva;

	void Start(){
		transformacijasLogs = GetComponent<RectTransform> ();
	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais Klikskis uz objekta!");

	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta objekta vilksana!");

	}

	public void OnDrag(PointerEventData notikums){
		transformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;

	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Objekta vilksana partraukta !");

	}




}
