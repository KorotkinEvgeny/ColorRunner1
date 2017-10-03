using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainTrigger : MonoBehaviour {

	[SerializeField]
	public GameObject train;
	
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {

			train.SendMessage ("IncreaseSpeed");
		}
	}
}
