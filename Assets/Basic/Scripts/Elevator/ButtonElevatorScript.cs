using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonElevatorScript : MonoBehaviour {

	public delegate void PushAction();
	public static event PushAction OnPush;



	private Animator buttonAnimator;

	// Use this for initialization
	void Start () {


		buttonAnimator = GetComponent<Animator> ();

	}

	public void ButtonPress(){
		buttonAnimator.SetTrigger ("ButtonPush");
		OnPush ();
	}
		

}
