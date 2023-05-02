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
		public string teksts, teksts2;

		public GameObject ievadesLauks;
		public GameObject ievadesLauks2;
		public GameObject tekstaAttelosana;

		public void uzglabaTekstu(){
		teksts = ievadesLauks.GetComponent<InputField>().text;
		teksts2 = ievadesLauks2.GetComponent<InputField> ().text;
		tekstaAttelosana.GetComponent<Text>().text = "Ceĺotájs/Fotográfe "+teksts.ToUpper()+" ir "+teksts2+" gadus vecs/veca!";



		
	}
}

