using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class VardaParadisana : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
		public string teksts;

		public GameObject ievadesLauks;

		public GameObject tekstaAttelosana;

		public void uzglabaTekstu(){
			teksts = ievadesLauks.GetComponent<Text>().text;
			tekstaAttelosana.GetComponent<Text>().text = "Sveiks "+teksts.ToUpper()+"!";



		
	}
}

