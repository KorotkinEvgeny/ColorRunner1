using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : MonoBehaviour {

	public float deathTime;

	void Start () {


		GameObject.Destroy(gameObject,deathTime);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision coll){
		if (coll.collider.tag == "Freeze" ) {
		coll.collider.attachedRigidbody.isKinematic = true;
		Debug.Log (coll.collider.name);
		}

		Destroy (gameObject);
	}
}
