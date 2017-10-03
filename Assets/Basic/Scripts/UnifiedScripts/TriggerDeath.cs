using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDeath : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
            Debug.Log("Enter the collider");
			SceneManager.LoadSceneAsync ("mainRunLevel");
		}
	}
}
