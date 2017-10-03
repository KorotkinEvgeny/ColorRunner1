using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {

	public Transform bulletPrefab;
	public Transform gunEnd;
	public float forcePower;
	public float timeSlowing;

	void Update () {

		//if (Input.GetButtonDown ("Fire1")) {

		//	Rigidbody bulletInstance;

		//	bulletInstance = Instantiate(bulletPrefab,gunEnd.position,gunEnd.rotation);
		//	bulletInstance.AddForce (gunEnd.forward * forcePower);
///
 	//	}

		//if (Input.GetButtonDown ("Fire2")) {
		//	//TODO: remove it to another class TimeManager
		//	if (Time.timeScale == 1.0F)
		//		Time.timeScale = timeSlowing;
		//	else
		//		Time.timeScale = 1.0F;
		//	Time.fixedDeltaTime = 0.02F * Time.timeScale;
		//}

		//if (Input.GetKey (KeyCode.E)) {
		//	RaycastHit hit;
		//	if (Physics.Raycast (gunEnd.position, gunEnd.forward, out hit, 10f)) 
		//	{
		//		Debug.DrawRay (gunEnd.position,gunEnd.forward, Color.black);
		//		if (hit.collider.gameObject.CompareTag ("Button")) {
		//			hit.collider.gameObject.SendMessage ("ButtonPress");
		//		}
		//	}
		//}


	}
}
