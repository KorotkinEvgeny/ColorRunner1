using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class TrainMovement : MonoBehaviour {

	private float trainSpeed = 0f;
	private const float speedIncrement = 65f;
	private const float TIMEtoDEATH = 10f;

	void Update () {

		transform.Translate(new Vector3(-1,0,0) * Time.deltaTime * trainSpeed);
		
	}

	public void IncreaseSpeed(){
		trainSpeed += speedIncrement;
		StartCoroutine (DestroyWhenDone());
	}

	public IEnumerator DestroyWhenDone(){

		yield return new WaitForSeconds (TIMEtoDEATH);
		Destroy (this.gameObject);
	}
}
