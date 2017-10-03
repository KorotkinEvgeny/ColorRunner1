using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorUpTrigger : MonoBehaviour {





	void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Player"))
        {
            other.transform.parent = gameObject.transform;
			SendMessageUpwards ("ElevatorDoorsClose");
			Debug.Log("Player in elevator");
        }
    }


	void OnTriggerExit (Collider other) {

        if (other.CompareTag("Player"))
        {
            other.transform.parent = null;

            SendMessageUpwards("Close");
			Debug.Log("Player out of elevator");
        }
    }
}
