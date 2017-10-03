using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour {

	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		transform.position = transform.position + (- Vector3.forward *0.5f);
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}
