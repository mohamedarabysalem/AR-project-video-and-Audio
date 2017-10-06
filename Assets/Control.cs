using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	// Use this for initialization
	public float rotationSpeed=70.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.FindWithTag("house").transform.Rotate(0, 0, rotationSpeed * Time.deltaTime );
		GameObject.FindWithTag("house1").transform.Rotate(0, 0, rotationSpeed * Time.deltaTime );
		GameObject.FindWithTag("house2").transform.Rotate(0, 0, rotationSpeed * Time.deltaTime );


		
	}
}
