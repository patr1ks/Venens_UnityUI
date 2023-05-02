using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject Fotografe;
	public GameObject Celotajs;
	public GameObject kurpes1;
	public GameObject bikses1;
	public GameObject cepure1;
	public GameObject krekls1;
	public GameObject aksesuars;
	public GameObject SKurpes;
	public GameObject SBikses;
	public GameObject SKrekls;
	public GameObject SBrilles;
	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;
	public GameObject sliderGarums;
	public GameObject sliderPlatums;
	public float Garums;
	public float Platums;


	public void izkritosais(int skaitlis){
		if (skaitlis == 0) {
			mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs [0];
		}
		if (skaitlis == 1) {
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [1];
		}
	}

	public void FotografesAttelosana(bool vertiba){
		Fotografe.SetActive (vertiba);
	}

	public void CelotajaAttelosana(bool vertiba){
		Celotajs.SetActive (vertiba);
	}

	public void kurpes1Attelosana(bool vertiba){
		kurpes1.SetActive (vertiba);
	}
	public void bikses1Attelosana(bool vertiba){
		bikses1.SetActive (vertiba);
	}
	public void cepure1Attelosana(bool vertiba){
		cepure1.SetActive (vertiba);
	}
	public void krekls1Attelosana(bool vertiba){
		krekls1.SetActive (vertiba);
	}
	public void aksesuarsAttelosana(bool vertiba){
		aksesuars.SetActive (vertiba);
	}
	public void SKurpesAttelosana(bool vertiba){
		SKurpes.SetActive (vertiba);
	}
	public void SBiksesAttelosana(bool vertiba){
		SBikses.SetActive (vertiba);
	}
	public void SKreklsAttelosana(bool vertiba){
		SKrekls.SetActive (vertiba);
	}
	public void SBrillesAttelosana(bool vertiba){
		SBrilles.SetActive (vertiba);
	}

	public void mainitGarumu(){
		Garums = sliderGarums.GetComponent<Slider> ().value;
		mainigaisAttels.transform.localScale = new Vector2 (Platums,Garums);
		kurpes1.transform.localScale = new Vector2 (Platums,Garums);
		bikses1.transform.localScale = new Vector2 (Platums,Garums);
		aksesuars.transform.localScale = new Vector2 (Platums,Garums);
		cepure1.transform.localScale = new Vector2 (Platums,Garums);
		krekls1.transform.localScale = new Vector2 (Platums,Garums);
		SKrekls.transform.localScale = new Vector2 (Platums,Garums);
		SKurpes.transform.localScale = new Vector2 (Platums,Garums);
		SBikses.transform.localScale = new Vector2 (Platums,Garums);
		SBrilles.transform.localScale = new Vector2 (Platums,Garums);
	}

	public void mainitPlatumu(){
		 Platums = sliderPlatums.GetComponent<Slider> ().value;
		mainigaisAttels.transform.localScale = new Vector2 (Platums, Garums);
		kurpes1.transform.localScale = new Vector2 (Platums,Garums);
		bikses1.transform.localScale = new Vector2 (Platums,Garums);
		aksesuars.transform.localScale = new Vector2 (Platums,Garums);
		cepure1.transform.localScale = new Vector2 (Platums,Garums);
		krekls1.transform.localScale = new Vector2 (Platums,Garums);
		SKrekls.transform.localScale = new Vector2 (Platums,Garums);
		SKurpes.transform.localScale = new Vector2 (Platums,Garums);
		SBikses.transform.localScale = new Vector2 (Platums,Garums);
		SBrilles.transform.localScale = new Vector2 (Platums,Garums);
	}
}
